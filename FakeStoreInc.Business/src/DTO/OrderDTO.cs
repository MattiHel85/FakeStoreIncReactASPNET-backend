
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class OrderReadDTO : BaseEntity
    {
        public Status OrderStatus { get; set;}
        public PaymentMethod PaymentMethod { get; set; }
        public Guid UserId { get; set;}
        public IEnumerable<OrderDetailReadDTO>? OrderDetails { get; set;}
    }

    public class OrderUpdateDTO
    {
        public Status OrderStatus { get; set;}
        public PaymentMethod PaymentMethod { get; set; }
        public Guid UserId { get; set;}
        public IEnumerable<OrderDetailUpdateDTO>? OrderDetails { get; set;}
    }

    public class OrderCreateDTO
    {
        public Status OrderStatus { get; set;} = Status.Pending;
        public PaymentMethod PaymentMethod { get; set; }
        public Guid UserId { get; set;}
        public IEnumerable<OrderDetailCreateDTO>? OrderDetails { get; set;}
    }
}