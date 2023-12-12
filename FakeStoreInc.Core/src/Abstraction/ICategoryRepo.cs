using FakeStoreInc.Core.src.Entity.Category;
using FakeStoreInc.Core.src.Parameter;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface ICategoryRepo
    {

        IEnumerable<Category> GetAll(GetAllParams options);

        Category GetOneById(Guid id);
        Category CreateOne(Category category);
        Category UpdateOne(Category category);
        bool DeleteOne(Guid id);
    }
}