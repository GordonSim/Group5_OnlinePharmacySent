using Group5_OnlinePharmacy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group5_OnlinePharmacy.Configurations.Entities
{
    public class SymptomSeed : IEntityTypeConfiguration<Symptom>
    {
        public void Configure(EntityTypeBuilder<Symptom> builder)
        {
            builder.HasData(
                new Symptom
                {
                    Id = 1,
                    Name = "Cough",
                    Description = "A reflex action to clear airways of mucus, dust, or foreign particles."
                },
                new Symptom
                {
                    Id = 2,
                    Name = "Diarrhea",
                    Description = "Frequent, loose, or watery stools, often caused by an infection."
                },
                new Symptom
                {
                    Id = 3,
                    Name = "Eye Care",
                    Description = "Symptoms affecting the eyes, such as dryness or irritation."
                },
                new Symptom
                {
                    Id = 4,
                    Name = "Flu",
                    Description = "A common viral infection causing fever, chills, and muscle aches."
                },
                new Symptom
                {
                    Id = 5,
                    Name = "Indigestion",
                    Description = "Discomfort in the stomach associated with difficulty digesting food."
                },
                new Symptom
                {
                    Id = 6,
                    Name = "Pain",
                    Description = "Physical discomfort or suffering caused by injury or illness."
                }
            );
        }
    }
}