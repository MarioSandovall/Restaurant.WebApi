using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BranchOffice : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string StateProvince { get; set; }

        [Required]
        [StringLength(500)]
        public string Town { get; set; }

        [Required]
        [StringLength(500)]
        public string Suburb { get; set; }

        [Required]
        [StringLength(500)]
        public string Street { get; set; }

        [Required]
        [StringLength(50)]
        public string OutdoorNumber { get; set; }

        public int PostalCode { get; set; }

        public bool Active { get; set; } = true;

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
