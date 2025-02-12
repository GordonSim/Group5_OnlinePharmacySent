namespace Group5_OnlinePharmacy.Domain
{
    public class OrderItem
    {
        public int Id { get; set; }   // PK
        public int Qty { get; set; }
        public float ItemPrice { get; set; }


        public int OrderId { get; set; }  // FK. Note the naming convention.
        public Order Order { get; set; }  // Nav Prop. Note the naming convention.

        public int MedicineId { get; set; } // FK. Note the naming convention.
        public Medicine Medicine { get; set; } // Nav Prop. Note the naming convention.
    }
}
