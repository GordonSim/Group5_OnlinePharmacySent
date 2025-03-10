﻿using Group5_OnlinePharmacy.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;

namespace Group5_OnlinePharmacy.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<Group5_OnlinePharmacyUser>
    {
        public void Configure(EntityTypeBuilder<Group5_OnlinePharmacyUser> builder)
        {
            var hasher = new PasswordHasher<Group5_OnlinePharmacyUser>();
            builder.HasData(
                new Group5_OnlinePharmacyUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login
                }
                );


        }
    }
}
