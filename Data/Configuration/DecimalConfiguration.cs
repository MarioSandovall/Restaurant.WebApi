using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Configuration
{
    internal static class DecimalConfiguration
    {
        public static void Configurate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(10,2)");
            modelBuilder.Entity<OrderDetail>().Property(x => x.Price).HasColumnType("decimal(10,2)");
            modelBuilder.Entity<CashRegister>().Property(x => x.Quantity).HasColumnType("decimal(10,2)");
        }
    }
}
