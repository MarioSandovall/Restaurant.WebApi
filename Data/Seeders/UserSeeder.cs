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
                new UserEf {Id = 1, Name = "Mario Sandoval", Password = "Admin", Email="mario_sandovall@outlook.com"}
            };

            var roles = new[]
            {
                new RoleEf {Id = (int)RoleEnum.Cashier, Name ="Cashier"},
                new RoleEf {Id = (int)RoleEnum.Chef,  Name = "Chef"},
                new RoleEf {Id = (int)RoleEnum.Admin,  Name = "Administrator"}
            };

            var userRoles = new[]
            {
                new UserRoleEf {UserId = 1, RoleId = (int) RoleEnum.Admin}
            };

            foreach (var user in users)
            {
                AddUser(user.Id, user.Name, user.Email, user.Password);
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

        private static void AddUser(int id, string name, string email, string password)
        {
            _modelBuilder.Entity<UserEf>().HasData(new UserEf
            {
                Id = id,
                Name = name,
                Email = email,
                Password = password
            });
        }

        private static void AddRole(int id, string name)
        {
            _modelBuilder.Entity<RoleEf>().HasData(new RoleEf()
            {
                Id = id,
                Name = name,
                Description = name
            });
        }

        private static void AddUserRole(int userId, int roleId)
        {
            _modelBuilder.Entity<UserRoleEf>().HasData(new UserRoleEf()
            {
                UserId = userId,
                RoleId = roleId
            });
        }
    }
}
