using Domain.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProductEf : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }

        [Required]
        public decimal Price { get; set; }

        public bool Active { get; set; } = true;

        public int RestaurantId { get; set; }
        public RestaurantEf Restaurant { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategoryEf ProductCategory { get; set; }

        public ICollection<ProductIngredientEf> ProductIngredients { get; set; }

    }
}
