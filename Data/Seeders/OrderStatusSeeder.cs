using Domain.Entities;
using Domain.Utils;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeders
{
    internal static class OrderStatusSeeder
    {
        private static ModelBuilder _modelBuilder;
        public static void Seed(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;

            AddPaymentType((int)OrderStatusEnum.Pending, "Pending");
            AddPaymentType((int)OrderStatusEnum.Delivered, "Delivered");
            AddPaymentType((int)OrderStatusEnum.Cancel, "Cancelled");
        }

        private static void AddPaymentType(int id, string name)
        {
            _modelBuilder.Entity<OrderStatusEf>().HasData(
                new OrderStatusEf { Id = id, Name = name });
        }
    }
}
