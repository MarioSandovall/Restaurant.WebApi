using Domain.Entities;
using Domain.Utils;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeders
{
    internal static class UserSeeder
    {
        private static ModelBuilder _modelBuilder;
        public static void Seed(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;

            var users = new[]
            {
                new User() {Id = 1, Name = "Administrador", Password = "Admin"}
            };

            var roles = new[]
            {
                new Role() {Id = (int)RoleEnum.Cashier, Name ="Cashier"},
                new Role() {Id = (int)RoleEnum.Chef,  Name = "Chef"},
                new Role() {Id = (int)RoleEnum.Admin,  Name = "Administrador"}
            };

            var userRoles = new[]
            {
                new UserRole() {UserId = 1, RoleId = (int) RoleEnum.Admin}
            };

            foreach (var user in users)
            {
                AddUser(user.Id, user.Name, user.Password);
            }

            foreach (var role in roles)
            {
                AddRole(role.Id, role.Name);
            }

            foreach (var userRole in userRoles)
            {
                AddUserRole(userRole.UserId, userRole.RoleId);
            }

        }

        private static void AddUser(int id, string name, string password)
        {
            _modelBuilder.Entity<User>().HasData(new User()
            {
                Id = id,
                Name = name,
                Password = password,
                Active = true
            });
        }

        private static void AddRole(int id, string name)
        {
            _modelBuilder.Entity<Role>().HasData(new Role()
            {
                Id = id,
                Name = name,
                Description = name
            });
        }

        private static void AddUserRole(int userId, int roleId)
        {
            _modelBuilder.Entity<UserRole>().HasData(new UserRole()
            {
                UserId = userId,
                RoleId = roleId
            });
        }
    }
}
