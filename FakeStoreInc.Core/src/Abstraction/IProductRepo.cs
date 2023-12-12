using FakeStoreInc.Core.src.Entity.Product;
using FakeStoreInc.Core.src.Parameter;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll(GetAllParams options);
        Product GetOneByID(Guid id);
        Product CreateOne(Product product);
        Product UpdateOne(Product product);
        bool DeleteOne(Guid id);
    }
}