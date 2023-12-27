namespace FakeStoreInc.Core.src.Entity
{
    public class Order : BaseEntity
    {
        public Status OrderStatus { get; set;}
        public PaymentMethod PaymentMethod { get; set; }
        public Guid UserId { get; set;}
        public IEnumerable<OrderDetail>? OrderDetails { get; set;}
    }

    public enum Status
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    public enum PaymentMethod
    {
        CreditCard,
        Bill,
        Credit,
        MobilePay
    }

}