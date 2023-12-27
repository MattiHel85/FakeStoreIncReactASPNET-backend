namespace FakeStoreInc.Core.src.Entity
{
    public class Product : BaseEntity
    {
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public string[]? Image { get; set; }
        public string? Price { get; set; }
        public int StockQuantity { get; set; }
        public Guid CategoryId { get; set;}
        public IEnumerable<ProductSize>? Sizes { get; set;}
        public IEnumerable<ProductColor>? Colors { get; set;}
    }

    public class ProductSize : BaseEntity
    {
        public int Value { get; set;}
        public Guid ProductId { get; set; }
    }
    public class ProductColor : BaseEntity
    {
        public int Value { get; set;}
        public Guid ProductId { get; set; }
    }
}