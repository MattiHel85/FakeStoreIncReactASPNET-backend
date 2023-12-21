using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.WebAPI.src.Database;


namespace FakeStoreInc.WebAPI.src.Repository
{
    public class ProductRepo : BaseRepo<Product>, IProductRepo
    {
        public ProductRepo(DatabaseContext databaseContext) : base(databaseContext)
        {            
        }
        // public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(Guid categoryId, GetAllOptions getAllOptions)
        // {
            
        // }
    }
}