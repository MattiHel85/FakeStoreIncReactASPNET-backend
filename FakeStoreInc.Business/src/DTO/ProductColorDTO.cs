using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class ProductColorReadDTO : BaseEntity
    {
        public int Value { get; set;}
        public IEnumerable<Product>? Products { get; set;}
    }
    public class ProductColorCreateDTO
    {
        public int Value { get; set;}
        public IEnumerable<Product>? Products { get; set;}
    }
    public class ProductColorUpdateDTO
    {
        public int Value { get; set;}
        public IEnumerable<Product>? Products { get; set;}
    }
}