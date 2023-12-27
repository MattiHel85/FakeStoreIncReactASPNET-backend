using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class ProductSizeReadDTO : BaseEntity
    {
        public int Value { get; set;}
        public IEnumerable<Product>? Products { get; set;}
    }
    public class ProductSizeCreateDTO
    {
       public int Value { get; set;}
        public IEnumerable<Product>? Products { get; set;}
    }
    public class ProductSizeUpdateDTO
    {
        public int Value { get; set;}
        public IEnumerable<Product>? Products { get; set;}
    }
}