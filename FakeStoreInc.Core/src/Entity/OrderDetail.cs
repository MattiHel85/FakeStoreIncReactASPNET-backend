namespace FakeStoreInc.Core.src.Entity
{
    public class OrderDetail : TimeStamp
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set;}
        public Guid SizeId { get; set; }
        public Guid ColorId { get; set; }
    }
}