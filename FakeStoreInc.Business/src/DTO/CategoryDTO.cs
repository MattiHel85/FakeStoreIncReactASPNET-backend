using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class CategoryReadDTO : BaseEntity
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; }
    }

    public class CategoryCreateDTO
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
    }

    public class CategoryUpdateDTO
    {
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
