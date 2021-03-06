﻿using Domain.Interfaces;
using Domain.Utils;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class OrderEf : IEntity
    {
        public int Id { get; set; }

        public int OrderNumber { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        public OrderStatusEnum Status { get; set; }

        public int CashRegisterId { get; set; }
        public CashRegisterEf CashRegister { get; set; }

        public int? CashierId { get; set; }
        public UserEf Cashier { get; set; }

        public PaymentTypeEnum PaymentType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
