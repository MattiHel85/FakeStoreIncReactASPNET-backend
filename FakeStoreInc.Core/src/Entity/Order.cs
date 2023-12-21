namespace FakeStoreInc.Core.src.Entity
{
    public class Order : BaseEntity
    {
        public Status OrderStatus { get; set;}
        public string? PaymentMethod { get; set; }
        public Guid UserId { get; set;}
        public ICollection<OrderItem>? OrderItems { get; set;}
    }

    public enum Status
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

}