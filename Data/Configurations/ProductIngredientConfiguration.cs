using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Configurations
{
    internal static class ProductIngredientConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductIngredientEf>()
                .HasKey(pi => new { pi.ProductId, pi.IngredientId });

            modelBuilder.Entity<ProductIngredientEf>()
                .HasOne(p => p.Product)
                .WithMany(pi => pi.ProductIngredients)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductIngredientEf>()
                .HasOne(i => i.Ingredient)
                .WithMany(pi => pi.ProductIngredients)
                .HasForeignKey(pi => pi.IngredientId);
        }
    }
}
