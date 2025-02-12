using Group5_OnlinePharmacy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group5_OnlinePharmacy.Configurations.Entities
{
    public class AllergySeed : IEntityTypeConfiguration<Allergy>
    {
        public void Configure(EntityTypeBuilder<Allergy> builder)
        {
            builder.HasData(
                new Allergy
                {
                    Id = 1,
                    Severity = "High",
                    Reaction = "Swelling and Rash",
                    CustomerId = 1,  // John Doe
                    MedicineId = 4 // Amoxicillin
                },
                new Allergy
                {
                    Id = 2,
                    Severity = "Mild",
                    Reaction = "Itchy Skin",
                    CustomerId = 1,  // Jane Smith
                    MedicineId = 3 // Cetirizine
                }
            );

        }
    }
}
