using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class RestaurantEf
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }
    }
}
