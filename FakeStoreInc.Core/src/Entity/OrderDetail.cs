namespace FakeStoreInc.Core.src.Entity
{
    public class OrderDetail : TimeStamp
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public Guid OrderId { get; set;}
        public Order? Order { get; set;}
        public ProductSize? Size { get; set;}
        public ProductColor? Color { get; set;}
    }
}