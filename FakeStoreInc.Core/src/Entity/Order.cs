namespace FakeStoreInc.Core.src.Entity
{
    public class Order : BaseEntity
    {
        public Guid UserId { get; set;}
        public User? User { get; set;}
        public IEnumerable<OrderDetail>? OrderDetails { get; set;}
    }
}