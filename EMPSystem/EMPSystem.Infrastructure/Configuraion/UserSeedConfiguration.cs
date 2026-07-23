using EMPSystem.Application.Interfaces;
using EMPSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMPSystem.Infrastructure.Configuraion
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = new Guid("7f8e3a9d-2b14-4f4c-a9d7-3d8b2a1c5e91"),
                    FirstName = "Admin",

                    LastName = "User",

                    Email = "admin@gmail.com",
                    Role = "Admin",

                    Provider = "Local",
                    PasswordHash = "Admin@1234",
                    CreatedDate = new DateTime(2026, 7, 23),

                }

            );
        }
    }
}
