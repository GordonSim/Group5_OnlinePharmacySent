using Group5_OnlinePharmacy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group5_OnlinePharmacy.Configurations.Entities
{
    public class OrderSeed : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order
                {
                    Id = 1,
                    OrderDate = new DateTime(2025, 1, 15, 19, 15, 0),
                    TotalPrice = 99.99f,
                    ShippingAddress = "123 Main St, Singapore",
                    PaymentStatus = "Paid",
                    CustomerId = 1 // Admin
                },
                new Order
                {
                    Id = 2,
                    OrderDate = new DateTime(2025, 1, 16, 10, 15, 0), // January 16, 2025, 10:15 AM
                    TotalPrice = 89.50f,
                    ShippingAddress = "456 Marina Bay, Singapore",
                    PaymentStatus = "Pending",
                    CustomerId = 1 // Admin
                },
                new Order
                {
                    Id = 3,
                    OrderDate = new DateTime(2025, 1, 17, 16, 45, 0), // January 17, 2025, 4:45 PM
                    TotalPrice = 120.75f,
                    ShippingAddress = "789 Tampines Street, Singapore",
                    PaymentStatus = "Failed",
                    CustomerId = 1 // Admin

                }
            );
        }
    }
}
