namespace Group5_OnlinePharmacy.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        //public string Role { get; set; }


        public string? AspNetUserIdId { get; set; }                 // FK 
        //public Group5_OnlinePharmacyUserId AspNetUserId { get; set; } // Nav Property 

        public ICollection<Allergy> Allergies { get; set; } = new List<Allergy>();  // Nav Property 
        public ICollection<Order> Orders { get; set; } = new List<Order>();         // Nav Property 
    }
}
