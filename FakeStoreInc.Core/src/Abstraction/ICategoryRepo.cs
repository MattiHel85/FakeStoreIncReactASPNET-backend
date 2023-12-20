using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface ICategoryRepo
    {

        IEnumerable<Category> GetAll(GetAllOptions options);

        Category GetOneById(Guid id);
        Category CreateOne(Category category);
        Category UpdateOne(Category category);
        bool DeleteOne(Guid id);
    }
}