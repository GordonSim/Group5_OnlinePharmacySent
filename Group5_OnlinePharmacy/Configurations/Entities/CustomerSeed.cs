using Group5_OnlinePharmacy.Data;
using Group5_OnlinePharmacy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group5_OnlinePharmacy.Configurations.Entities
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Admin UserId",
                    Email = "admin@example.com",
                    Password = "hashed_password_3",
                    Address = "789 Admin St, Singapore",
                    PhoneNumber = "90011234",
                    //Role = "Admin",
                    AspNetUserIdId = "3781efa7-66dc-47f0-860f-e506d04102e4" // Unique for Admin
                }
            );
        }
    }
}
