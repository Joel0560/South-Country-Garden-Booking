using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace south_country_garden.Model
{
    public class audit_trail
    {
        [Key]
        public int audit_id { get; set; }

        [ForeignKey("accounts")]
        public int account_id { get; set; }

        public accounts accounts { get; set; } = null!;

        [ForeignKey("booking_records")]
        public int booking_id { get; set; }

        public booking_records booking_records { get; set; } = null!;

        public string datetime { get; set; }

        public string action { get; set; }
    }
}
