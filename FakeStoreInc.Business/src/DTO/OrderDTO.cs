
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class OrderReadDTO : BaseEntity
    {
        public Guid UserId { get; set;}
        public User User { get; set;}
        public IEnumerable<OrderDetailReadDTO>? OrderDetails { get; set;}
    }

    public class OrderUpdateDTO
    {
        public Guid UserId { get; set;}
        public User User { get; set;}
        public IEnumerable<OrderDetailUpdateDTO>? OrderDetails { get; set;}
    }

    public class OrderCreateDTO
    {
        public Guid UserId { get; set;}
        public User User { get; set;}
        public IEnumerable<OrderDetailCreateDTO>? OrderDetails { get; set;}
    }
}