namespace Group5_OnlinePharmacy.Domain
{
    public class Order
    {
        public int Id { get; set; }  // PK
        public DateTime OrderDate { get; set; }
        public float TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        public string PaymentStatus { get; set; }

        
        public int CustomerId { get; set; }   // FK. Note the naming convention.
        public Customer Customer { get; set; }  // Nav Prop. Note the naming convention.

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();  // Nav Prop
    }
}
