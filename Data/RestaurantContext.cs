using Data.Configuration;
using Data.Seeders;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<BranchOffice> BranchOffice { get; set; }
        public DbSet<CashRegister> CashRegister { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductIngredient> ProductIngredient { get; set; }
        public DbSet<CashRegisterStatus> CashRegisterStatus { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seeders
            UserSeeder.Seed(modelBuilder);
            PaymentSeeder.Seed(modelBuilder);
            OrderStatusSeeder.Seed(modelBuilder);

            //Configurations
            DecimalConfiguration.Configurate(modelBuilder);
            UserRoleConfiguration.Configurate(modelBuilder);
            ProductIngredientConfiguration.Configurate(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

    }

}
