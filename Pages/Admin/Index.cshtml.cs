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
    public class IndexModel : PageModel
    {
        private readonly south_country_garden.Data.ApplicationDbContext _context;

        public IndexModel(south_country_garden.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<booking_records> booking_records { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.booking_records != null)
            {
                booking_records = await _context.booking_records.ToListAsync();
            }
            Console.WriteLine("hello");
        }

        public IActionResult OnPost()
        {
            HttpContext.Session.SetString("LogInState", "false");
            HttpContext.Session.SetString("IsManager", "false");
            return RedirectToPage("../Index");
        }
    }
}
