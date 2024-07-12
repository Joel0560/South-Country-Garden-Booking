using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using south_country_garden.Data;
using south_country_garden.Model;

namespace south_country_garden.Pages.Admin
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        [BindProperty]
        public accounts accounts { get; set; }

        private readonly south_country_garden.Data.ApplicationDbContext _context;

        public LoginModel(south_country_garden.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("LogInState") == "true")
            {
                return RedirectToPage("Index");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            accounts user = _context.accounts.FirstOrDefault(u => u.username == accounts.username && u.password == accounts.password);

            if (user == null)
            {
                ModelState.AddModelError("accounts.password", "Invalid");
                return Page();
            }

            HttpContext.Session.SetString("LogInState", "true");
            HttpContext.Session.SetString("IsManager", user.is_manager);
            HttpContext.Session.SetString("AccountID", user.account_id.ToString());

            return RedirectToPage("Index");
        }
    }
}
