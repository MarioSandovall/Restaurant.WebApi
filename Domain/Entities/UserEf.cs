﻿using Domain.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class UserEf : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(25)]
        public string LastName { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(25)]
        public string Password { get; set; }

        public bool Active { get; set; } = true;

        public ICollection<UserRoleEf> UserRoles { get; set; }

        public int? RestaurantId { get; set; }
        public RestaurantEf Restaurant { get; set; }

    }
}
