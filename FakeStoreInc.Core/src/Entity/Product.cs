namespace FakeStoreInc.Core.src.Entity
{
    public class Product : BaseEntity
    {
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Price { get; set; }
        public int StockQuantity { get; set; }
        public Guid CategoryId { get; set;}
        public Category? Category { get; set;}
        public ICollection<OrderItem>? OrderItems { get; set;}
    }
}