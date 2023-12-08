namespace FakeStoreInc.Core.src.Entity
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string StockQuantity { get; set; }
        public int CategoryId { get; set;}
    }
}