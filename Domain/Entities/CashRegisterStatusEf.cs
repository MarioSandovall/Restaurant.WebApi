﻿using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class CashRegisterStatusEf : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
