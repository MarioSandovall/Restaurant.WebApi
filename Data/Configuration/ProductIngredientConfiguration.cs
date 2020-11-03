using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Configuration
{
    internal static class ProductIngredientConfiguration
    {
        public static void Configurate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductIngredient>()
                .HasKey(pi => new { pi.ProductId, pi.IngredientId });

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(p => p.Product)
                .WithMany(pi => pi.ProductIngredients)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(i => i.Ingredient)
                .WithMany(pi => pi.ProductIngredients)
                .HasForeignKey(pi => pi.IngredientId);
        }
    }
}
