namespace FakeStoreInc.Core.src.Entity.Order
{
    public class Order : BaseEntity
    {
        public string? OrderDate { get; set; }
        public Status OrderStatus { get; set;}
        public string? PaymentMethod { get; set; }
        public int UserId { get; set;}
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