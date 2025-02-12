using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Group5_OnlinePharmacy.Data;
using Group5_OnlinePharmacy.Configurations.Entities;

namespace Group5_OnlinePharmacy.Data
{
    public class Group5_OnlinePharmacyContext(DbContextOptions<Group5_OnlinePharmacyContext> options) : IdentityDbContext<Group5_OnlinePharmacyUser>(options)
    {

        public DbSet<Group5_OnlinePharmacy.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<Group5_OnlinePharmacy.Domain.Allergy> Allergy { get; set; } = default!;
        public DbSet<Group5_OnlinePharmacy.Domain.Medicine> Medicine { get; set; } = default!;
        public DbSet<Group5_OnlinePharmacy.Domain.Order> Order { get; set; } = default!;
        public DbSet<Group5_OnlinePharmacy.Domain.OrderItem> OrderItem { get; set; } = default!;
        public DbSet<Group5_OnlinePharmacy.Domain.Symptom> Symptom { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AllergySeed());
            builder.ApplyConfiguration(new MedicineSeed());
            builder.ApplyConfiguration(new OrderItemSeed());
            builder.ApplyConfiguration(new OrderSeed());
            builder.ApplyConfiguration(new SymptomSeed());
            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
