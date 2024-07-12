using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using south_country_garden.Data;
using south_country_garden.Model;

namespace south_country_garden.Pages.Admin_Controls
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public booking_records booking_records { get; set; }

        public audit_trail audit_trail { get; set; }

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            booking_records = _context.booking_records.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var recordFromDb = _context.booking_records.Find(booking_records.booking_id);
            if (recordFromDb != null)
            {
                TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
                DateTime currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZone);

                audit_trail = new audit_trail();
                audit_trail.account_id = Convert.ToInt32(HttpContext.Session.GetString("AccountID"));
                audit_trail.booking_id = booking_records.booking_id;
                audit_trail.datetime = currentDateTime.ToString();
                audit_trail.action = "Delete Record";

                recordFromDb.booking_status = "Deleted";

                _context.audit_trail.Add(audit_trail);
                await _context.SaveChangesAsync();

                TempData["success"] = "Booking deleted successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
