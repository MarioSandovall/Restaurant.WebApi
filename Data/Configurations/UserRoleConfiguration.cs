﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Configurations
{
    internal static class UserRoleConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRoleEf>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRoleEf>()
                .HasOne(u => u.User)
                .WithMany(ur => ur.UserRoles)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<UserRoleEf>()
                .HasOne(r => r.Role)
                .WithMany(ur => ur.UserRoles)
                .HasForeignKey(r => r.RoleId);
        }
    }
}
