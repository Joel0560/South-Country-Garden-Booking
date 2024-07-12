using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using south_country_garden.Model;

namespace south_country_garden.Pages.Admin
{
    public class AuditTrailModel : PageModel
    {
        private readonly south_country_garden.Data.ApplicationDbContext _context;

        public AuditTrailModel(south_country_garden.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<audit_trail> audit_trail { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.booking_records != null)
            {
                audit_trail = await _context.audit_trail.ToListAsync();
            }
        }
    }
}
