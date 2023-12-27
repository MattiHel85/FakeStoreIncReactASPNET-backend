namespace FakeStoreInc.Core.src.Entity
{
    public class OrderDetail : TimeStamp
    // public class OrderDetail : BaseEntity
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public Guid OrderId { get; set;}
        public Order? Order { get; set; }
        public Guid SizeId { get; set; }
        public ProductSize? Size { get; set; }
        public Guid ColorId { get; set; }
        public ProductColor? Color { get; set; }
    }
}