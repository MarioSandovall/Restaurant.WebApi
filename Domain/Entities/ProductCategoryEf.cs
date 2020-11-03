using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProductCategoryEf : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool Active { get; set; } = true;

        [StringLength(500)]
        public string ImagePath { get; set; }

        public int RestaurantId { get; set; }
        public RestaurantEf Restaurant { get; set; }

    }
}
