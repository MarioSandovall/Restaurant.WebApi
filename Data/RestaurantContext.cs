using Data.Configurations;
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

        public DbSet<UserEf> User { get; set; }
        public DbSet<RoleEf> Role { get; set; }
        public DbSet<OrderEf> Order { get; set; }
        public DbSet<TableEf> Table { get; set; }
        public DbSet<ProductEf> Product { get; set; }
        public DbSet<UserRoleEf> UserRole { get; set; }
        public DbSet<IngredientEf> Ingredient { get; set; }
        public DbSet<OrderDetailEf> OrderDetail { get; set; }
        public DbSet<OrderStatusEf> OrderStatus { get; set; }
        public DbSet<PaymentTypeEf> PaymentType { get; set; }
        public DbSet<BranchOfficeEf> BranchOffice { get; set; }
        public DbSet<CashRegisterEf> CashRegister { get; set; }
        public DbSet<RestaurantEf> Restaurant { get; set; }
        public DbSet<ProductCategoryEf> ProductCategory { get; set; }
        public DbSet<ProductIngredientEf> ProductIngredient { get; set; }
        public DbSet<CashRegisterStatusEf> CashRegisterStatus { get; set; }


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
