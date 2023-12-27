
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class OrderReadDTO : BaseEntity
    {
        public Status OrderStatus { get; set;}
        public PaymentMethod PaymentMethod { get; set; }
        public User? User {get; set;}
        public IEnumerable<OrderDetail>? OrderDetails { get; set;}
    }

    public class OrderUpdateDTO
    {
        public Status OrderStatus { get; set;}
        public PaymentMethod PaymentMethod { get; set; }
        public User? User {get; set;}
        public IEnumerable<OrderDetail>? OrderDetails { get; set;}
    }

    public class OrderCreateDTO
    {
        public Status OrderStatus { get; set;}
        public PaymentMethod PaymentMethod { get; set; }
        public User? User {get; set;}
        public IEnumerable<OrderDetail>? OrderDetails { get; set;}
    }
}