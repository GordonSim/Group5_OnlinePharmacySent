namespace Group5_OnlinePharmacy.Domain
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string? Description { get; set; }
        public int StockQty { get; set; }
        public string? ImageURL { get; set; }

        //Navigation Properties
        public ICollection<Allergy> Allergies { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
