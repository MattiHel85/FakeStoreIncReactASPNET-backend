namespace FakeStoreInc.Core.src.Entity
{
    public class OrderItem : BaseEntity
    {
        public Guid OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal PaymentMethod { get; set; }
        public Guid OrderId { get; set;}
        public Order? Order { get; set;}
        public Guid ProductId { get; set;}
        public Product? Product { get; set;}
    }
}