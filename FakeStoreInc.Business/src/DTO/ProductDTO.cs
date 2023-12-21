using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    namespace FakeStoreInc.Business.src.DTO
    {
        public class ProductReadDTO : BaseEntity
        {
            public string? ProductName { get; set; }
            public string? Description { get; set; }
            public string? Image { get; set; }
            public string? Price { get; set; }
            public int StockQuantity { get; set; }
            public Guid CategoryId { get; set; }
        }

        public class ProductCreateDTO
        {
            public string? ProductName { get; set; }
            public string? Description { get; set; }
            public string? Image { get; set; }
            public string? Price { get; set; }
            public int StockQuantity { get; set; }
            public Guid CategoryId { get; set; }
        }

        public class ProductUpdateDTO
        {
            public string? ProductName { get; set; }
            public string? Description { get; set; }
            public string? Image { get; set; }
            public string? Price { get; set; }
            public int StockQuantity { get; set; }
        }
    }
}