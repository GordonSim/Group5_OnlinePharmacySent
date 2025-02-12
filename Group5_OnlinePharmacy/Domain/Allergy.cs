namespace Group5_OnlinePharmacy.Domain
{
    public class Allergy
    {
        public int Id { get; set; }   // PK
        public string? Severity { get; set; }   // Allergy severity (Low, Medium, High)
        public string? Reaction { get; set; }   // Description of allergic reaction (nullable)


        public  int CustomerId { get; set; }   // FK. Note the naming convention.
        public Customer Customer { get; set; }  // Nav Prop. Note the naming convention.

        public int MedicineId { get; set; } // FK. Note the naming convention.
        public Medicine Medicine { get; set; } // Nav Prop. Note the naming convention.
    }
}
