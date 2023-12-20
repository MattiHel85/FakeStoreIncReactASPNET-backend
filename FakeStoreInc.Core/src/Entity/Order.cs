namespace FakeStoreInc.Core.src.Entity
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public Status OrderStatus { get; set;}
        public string? PaymentMethod { get; set; }
        public Guid UserId { get; set;}
        public User? User { get; set;}
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