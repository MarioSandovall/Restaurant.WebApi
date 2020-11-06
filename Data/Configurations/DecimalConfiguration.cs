using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Configurations
{
    internal static class DecimalConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEf>().Property(x => x.Price).HasColumnType("decimal(10,2)");
            modelBuilder.Entity<OrderDetailEf>().Property(x => x.Price).HasColumnType("decimal(10,2)");
            modelBuilder.Entity<CashRegisterEf>().Property(x => x.Quantity).HasColumnType("decimal(10,2)");
        }
    }
}
