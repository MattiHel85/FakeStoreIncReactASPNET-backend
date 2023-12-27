using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class OrderDetailReadDTO : BaseEntity
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set;}
        public ProductSizeReadDTO? Size { get; set;}
        public ProductColorReadDTO? Color { get; set;}
    }

    public class OrderDetailUpdateDTO
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set;}
        public ProductSizeUpdateDTO? Size { get; set;}
        public ProductColorUpdateDTO? Color { get; set;}
    }

    public class OrderDetailCreateDTO
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set;}
        public ProductSizeCreateDTO? Size { get; set;}
        public ProductColorCreateDTO? Color { get; set;}
    }
}