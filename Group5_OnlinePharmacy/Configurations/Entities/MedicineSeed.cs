using Group5_OnlinePharmacy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group5_OnlinePharmacy.Configurations.Entities
{
    public class MedicineSeed : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.HasData(
                // Cough
                new Medicine
                {
                    Id = 1,
                    Name = "Difflam",
                    Price = 8.99f,
                    Description = "Relieves sore throat and cough symptoms.",
                    StockQty = 50,
                    ImageURL = "Difflam.jpg"
                },
                new Medicine
                {
                    Id = 2,
                    Name = "Pei Pa Koa",
                    Price = 6.99f,
                    Description = "Traditional remedy for cough and sore throat.",
                    StockQty = 40,
                    ImageURL = "Pei Pa Koa.jpg"
                },

                // Diarrhea
                new Medicine
                {
                    Id = 3,
                    Name = "Lacteolfort",
                    Price = 4.99f,
                    Description = "Helps restore gut health and control diarrhea.",
                    StockQty = 30,
                    ImageURL = "Lacteolfort.jpg"
                },

                // Eye Care
                new Medicine
                {
                    Id = 4,
                    Name = "Moist Eye-mo",
                    Price = 5.49f,
                    Description = "Lubricates dry eyes and provides long-lasting relief.",
                    StockQty = 25,
                    ImageURL = "Moist Eye-mo.jpg"
                },

                // Flu
                new Medicine
                {
                    Id = 5,
                    Name = "Clarityne",
                    Price = 7.99f,
                    Description = "Relieves symptoms of allergies and hay fever.",
                    StockQty = 40,
                    ImageURL = "Clarityne.jpg"
                },

                // Indigestion
                new Medicine
                {
                    Id = 6,
                    Name = "Gaviscon",
                    Price = 6.49f,
                    Description = "Provides relief from acid reflux and heartburn.",
                    StockQty = 20,
                    ImageURL = "Gaviscon.jpg"
                },

                // Pain
                new Medicine
                {
                    Id = 7,
                    Name = "Panadol",
                    Price = 4.99f,
                    Description = "Effective relief for headaches, fever, and pain.",
                    StockQty = 100,
                    ImageURL = "Panadol.jpg"
                }
            );
        }
    }
}
