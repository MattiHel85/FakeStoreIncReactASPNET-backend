using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IProductRepo
    {
        Product CreateOne(Product product);
        IEnumerable<Product> GetAll(GetAllParams options);
        Product GetOne(Guid id);
        Product UpdateOne(Product product);
        bool DeleteOne(Guid id);
    }
}