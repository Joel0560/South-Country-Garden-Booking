using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using south_country_garden.Data;
using south_country_garden.Model;

namespace south_country_garden.Pages
{
    public class BookingModel : PageModel
    {
        private readonly south_country_garden.Data.ApplicationDbContext _context;

        public BookingModel(south_country_garden.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public booking_records booking_records { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            ValidateDate();

            if (!ModelState.IsValid || _context.booking_records == null || booking_records == null)
            {
                return Page();
            }

            SendEmail(booking_records);
            booking_records.booking_status = "Unconfirmed";
            _context.booking_records.Add(booking_records);
            await _context.SaveChangesAsync();
            
            TempData["success"] = "Booked successfully!";
            return RedirectToPage("./Index");
        }

        private void ValidateDate()
        {
            if (booking_records.event_date != null)
            {
                DateTime date = DateTime.ParseExact(booking_records.event_date, "yyyy-MM-dd", null);
                if (date < DateTime.Today) //prevents booking past date
                {
                    ModelState.AddModelError("booking_records.event_date", "Please book a valid date.");
                }
                else if (date < DateTime.Today.AddDays(30))
                {
                    ModelState.AddModelError("booking_records.event_date", "Bookings must be made at least a month in advance.");
                }
            }
        }

        private static void SendEmail(booking_records data)
        {
            try
            {
                MailMessage clientMail = new MailMessage();
                SmtpClient clientOne = new SmtpClient("smtp.office365.com");
                clientMail.From = new MailAddress("kris.p.bacon2023@outlook.com", "Kris P. Bacon");
                clientMail.To.Add(data.email);

                clientMail.Subject = "South Country Garden Booking";
                clientMail.IsBodyHtml = true;
                clientMail.Body = $"Greetings {data.name}!" +
                    $"<br><br>Thank you for booking South Country Garden. Please expect a response soon!";
                clientOne.EnableSsl = true;
                clientOne.Port = 587;
                clientOne.Credentials = new System.Net.NetworkCredential("kris.p.bacon2023@outlook.com", "SamplePassword123");
                clientOne.Send(clientMail);

                MailMessage scgMail = new MailMessage();
                SmtpClient clientTwo = new SmtpClient("smtp.office365.com");
                scgMail.From = new MailAddress("kris.p.bacon2023@outlook.com", "Kris P. Bacon");
                scgMail.To.Add("kris.p.bacon2023@outlook.com");

                scgMail.Subject = "New Client Booking";
                scgMail.IsBodyHtml = true;
                scgMail.Body = "Information on new client booking:<br><br>" +
                    $"<b>Full Name:</b> {data.name}<br><b>Contact Number:</b> {data.contact_number}<br>" +
                    $"<b>Email Address:</b> {data.email}<br>" +
                    $"<b>Address:</b> {data.address}<br><b>Additional Message:</b> {data.additional_message}";
                clientTwo.EnableSsl = true;
                clientTwo.Port = 587;
                clientTwo.Credentials = new System.Net.NetworkCredential("kris.p.bacon2023@outlook.com", "SamplePassword123");
                clientTwo.Send(scgMail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
