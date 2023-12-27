using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class OrderDetailReadDTO : BaseEntity
    {
        public int Quantity { get; set; }
        public Product? Product { get; set; }
        public Order? Order { get; set; }
        public ProductSize? Size { get; set; }
        public ProductColor? Color { get; set; }
    }

    public class OrderDetailUpdateDTO
    {
        public int Quantity { get; set; }
        public Product? Product { get; set; }
        public Order? Order { get; set; }
        public ProductSize? Size { get; set; }
        public ProductColor? Color { get; set; }
    }

    public class OrderDetailCreateDTO
    {
        public int Quantity { get; set; }
        public Product? Product { get; set; }
        public Order? Order { get; set; }
        public ProductSize? Size { get; set; }
        public ProductColor? Color { get; set; }
    }
}