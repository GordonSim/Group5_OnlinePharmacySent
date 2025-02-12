using Group5_OnlinePharmacy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group5_OnlinePharmacy.Configurations.Entities
{
    public class OrderItemSeed : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(
                new OrderItem
                {
                    Id = 1,
                    Qty = 2,
                    ItemPrice = 5.99f, // Example price for Paracetamol
                    OrderId = 1,  // Belongs to Order 1
                    MedicineId = 1 // Paracetamol
                },
                new OrderItem
                {
                    Id = 2,
                    Qty = 1,
                    ItemPrice = 7.49f, // Example price for Ibuprofen
                    OrderId = 1,  // Belongs to Order 1
                    MedicineId = 2 // Ibuprofen
                },
                new OrderItem
                {
                    Id = 3,
                    Qty = 3,
                    ItemPrice = 4.99f, // Example price for Cetirizine
                    OrderId = 2,  // Belongs to Order 2
                    MedicineId = 3 // Cetirizine
                },
                new OrderItem
                {
                    Id = 4,
                    Qty = 2,
                    ItemPrice = 9.99f, // Example price for Amoxicillin
                    OrderId = 3,  // Belongs to Order 3
                    MedicineId = 4 // Amoxicillin
                }
            );
        }
    }
}
