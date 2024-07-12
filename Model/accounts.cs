using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class accounts
    {
        [Key]
        public int account_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string username { get; set; }

        [MaxLength(50)]
        public string email_address { get; set; }

        [MaxLength(40)]
        public string first_name { get; set; }

        [MaxLength(40)]
        public string last_name { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [MaxLength(15)]
        public string is_manager { get; set; }

        public ICollection<audit_trail> audit_trails { get; } = new List<audit_trail>();
    }
}
