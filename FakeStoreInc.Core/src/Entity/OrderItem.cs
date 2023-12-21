namespace FakeStoreInc.Core.src.Entity
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal PaymentMethod { get; set; }
        public Guid OrderId { get; set;}
        public Guid ProductId { get; set;}
    }
}