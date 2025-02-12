using Microsoft.AspNetCore.Identity;

namespace Group5_OnlinePharmacy.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Group5_OnlinePharmacyUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Address{ get; set; }
        public string? Phone{ get; set; }
        public int? CustomerId { get; set; }  // Use as an element

    }
}
