using System.ComponentModel.DataAnnotations;

namespace UpsellPageAPI.Entities
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? Savings { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public string ActivityPageUrl { get; set; }

        [MaxLength(50)]
        public string Category { get; set; } // e.g., Top Activities, Luxury Activities
    }
    
    
    
}
