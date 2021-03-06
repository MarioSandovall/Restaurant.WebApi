﻿using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class TableEf : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool IsBussy { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }

        public bool Active { get; set; } = true;

        public int BranchOfficeId { get; set; }
        public BranchOfficeEf BranchOffice { get; set; }

    }
}
