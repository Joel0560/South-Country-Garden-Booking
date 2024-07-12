using System.ComponentModel.DataAnnotations;

namespace south_country_garden.Model
{
    public class booking_records
    {
        [Key]
        public int booking_id { get; set; }

        [Display(Name = "Company / Client Name")]
        [MaxLength(100)]
        [Required]
        public string name { get; set; }

        [Display(Name = "Contact Number")]
        [Phone(ErrorMessage = "Please enter a valid contact number")]
        [MinLength(2)]
        [MaxLength(30)]
        [Required]
        public string contact_number { get; set; }

        [Display(Name = "Home / Office Address")]
        [MaxLength(200)]
        public string? address { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [MaxLength(50)]
        [Required]
        public string email { get; set; }

        [Display(Name = "Additional Message")]
        public string? additional_message { get; set; }

        [Display(Name = "Remarks")]
        [MaxLength(255)]
        public string? remarks { get; set; }

        [Display(Name = "Payment Status")]
        [MaxLength(255)]
        public string? payment_status { get; set; }

        [Display(Name = "Booking Status")]
        [MaxLength(20)]
        public string? booking_status { get; set; }

        [Display(Name = "Nature / Title of Event")]
        [MaxLength(70)]
        public string? event_title { get; set; }

        [Display(Name = "Color Motif")]
        [MaxLength(255)]
        public string? color_motif { get; set; }

        [Display(Name = "Date of Event")]
        [MaxLength(10)]
        [Required]
        public string? event_date { get; set; }

        [Display(Name = "Church")]
        [MaxLength(50)]
        public string? church { get; set; }

        [Display(Name = "Venue")]
        [MaxLength(100)]
        public string? venue { get; set; }

        [Display(Name = "Time Prep")]
        [MaxLength(100)]
        public string? time_preparation { get; set; }

        [Display(Name = "Number of Pax")]
        [Range(1, 400)]
        public int? pax_number { get; set; }

        [Display(Name = "Event Time")]
        [MaxLength(100)]
        public string? event_time { get; set; }

        [Display(Name = "Total Package (PhP)")]
        [MaxLength(50)]
        public string? total_package { get; set; }

        [Display(Name = "On-The-Day Event Coordination")]
        [MaxLength(255)]
        public string? event_coordination { get; set; }

        [Display(Name = "Program Hosting")]
        [MaxLength(255)]
        public string? program_hosting { get; set; }

        [Display(Name = "Mobile Sound System")]
        [MaxLength(255)]
        public string? mobile_sound_system { get; set; }

        [Display(Name = "Lighting System")]
        [MaxLength(255)]
        public string? lighting_system { get; set; }

        [Display(Name = "On-Site Catering (pax)")]
        [MaxLength(255)]
        public string? catering { get; set; }

        [Display(Name = "Tiffany Chairs & Tables")]
        [MaxLength(255)]
        public string? tiffany_chairs_and_tables { get; set; }

        [Display(Name = "Red Carpet(s)")]
        [MaxLength(255)]
        public string? red_carpets { get; set; }

        [Display(Name = "Personalized Cake layer/s (1 layer Artificial Cake)")]
        [MaxLength(255)]
        public string? personalized_cake_layers { get; set; }

        [Display(Name = "Photo Gallery")]
        [MaxLength(255)]
        public string? photo_gallery { get; set; }

        [Display(Name = "Table Numbers")]
        [MaxLength(255)]
        public string? table_numbers { get; set; }

        [Display(Name = "Tarpaulin")]
        [MaxLength(255)]
        public string? tarpaulin { get; set; }

        [Display(Name = "Signature Frame")]
        [MaxLength(255)]
        public string? signature_frame { get; set; }

        [Display(Name = "Holding Area")]
        [MaxLength(255)]
        public string? holding_area_rooms { get; set; }

        [Display(Name = "LCD / Projector")]
        [MaxLength(255)]
        public string? lcd_and_projectors { get; set; }

        [Display(Name = "Event Extras (Doves, Wine, 18 Roses, 18 Candles)")]
        [MaxLength(255)]
        public string? event_extras { get; set; }

        [Display(Name = "Hair & Make Up Package")]
        [MaxLength(255)]
        public string? hair_and_make_up { get; set; }

        [Display(Name = "Giveaway")]
        [MaxLength(255)]
        public string? giveaway { get; set; }

        [Display(Name = "Photo & Video Coverage")]
        [MaxLength(255)]
        public string? photo_and_video_coverage { get; set; }

        [Display(Name = "Photo Booth")]
        [MaxLength(255)]
        public string? photo_booth { get; set; }

        [Display(Name = "Bridal Car")]
        [MaxLength(255)]
        public string? bridal_car { get; set; }

        [Display(Name = "Entourage / Church-Flower Arrangement")]
        [MaxLength(255)]
        public string? entourage_church_flower { get; set; }

        [Display(Name = "Additional Stage & Aisles Decors Altar Kit (Candles, Host, Wine, etc.)")]
        [MaxLength(255)]
        public string? additional_stages { get; set; }

        [Display(Name = "Beef Dish")]
        [MaxLength(255)]
        public string? beef { get; set; }

        [Display(Name = "Seafood (Fish)")]
        [MaxLength(255)]
        public string? seafood { get; set; }

        [Display(Name = "Pork Dish")]
        [MaxLength(255)]
        public string? pork { get; set; }

        [Display(Name = "Chicken Dish")]
        [MaxLength(255)]
        public string? chicken { get; set; }

        [Display(Name = "Pasta")]
        [MaxLength(255)]
        public string? pasta { get; set; }

        [Display(Name = "Vegetable")]
        [MaxLength(255)]
        public string? vegetable { get; set; }

        [Display(Name = "Rice")]
        [MaxLength(255)]
        public string? rice { get; set; }

        [Display(Name = "Dessert")]
        [MaxLength(255)]
        public string? dessert { get; set; }

        public ICollection<audit_trail> audit_trails { get; } = new List<audit_trail>();
    }
}
