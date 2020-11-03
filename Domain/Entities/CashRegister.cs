using Domain.Interfaces;
using Domain.Utils;
using System;

namespace Domain.Entities
{
    public class CashRegister : IEntity
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal Quantity { get; set; }

        public CashRegisterStatusEnum Status { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int BranchOfficeId { get; set; }
        public BranchOffice BranchOffice { get; set; }
    }
}
