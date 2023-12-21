using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class OrderItemReadDTO : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal PaymentMethod { get; set; }
        public Guid OrderId { get; set;}
        public Guid ProductId { get; set;}
    }

    public class OrderItemUpdateDTO
    {
        public int Quantity { get; set; }
        public decimal PaymentMethod { get; set; }
        public Guid OrderId { get; set;}
        public Guid ProductId { get; set;}
    }

    public class OrderItemCreateDTO
    {
        public int Quantity { get; set; }
        public decimal PaymentMethod { get; set; }
        public Guid OrderId { get; set;}
        public Guid ProductId { get; set;}
    }
}