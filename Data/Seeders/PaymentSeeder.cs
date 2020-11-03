using Domain.Entities;
using Domain.Utils;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeders
{
    internal static class PaymentSeeder
    {

        private static ModelBuilder _modelBuilder;
        public static void Seed(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;

            AddPaymentType((int)PaymentTypeEnum.Cash, "Cash");
            AddPaymentType((int)PaymentTypeEnum.CreditCard, "Credit Card");
            AddPaymentType((int)PaymentTypeEnum.Check, "Check");
        }

        private static void AddPaymentType(int id, string name)
        {
            _modelBuilder.Entity<PaymentTypeEf>().HasData(
                new PaymentTypeEf { Id = id, Name = name });
        }
    }
}
