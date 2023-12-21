using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.WebAPI.src.Database;

namespace FakeStoreInc.WebAPI.src.Repository
{
    public class CategoryRepo :BaseRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(DatabaseContext databaseContext) : base(databaseContext)
        {}
    }
}