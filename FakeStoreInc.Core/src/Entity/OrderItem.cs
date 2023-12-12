namespace FakeStoreInc.Core.src.Entity.OrderItem
{
    public class OrderItem : BaseEntity
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal PaymentMethod { get; set; }
        public int OrderId { get; set;}
        public int ProductId { get; set;}
    }
}