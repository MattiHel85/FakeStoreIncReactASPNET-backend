using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface ICategoryRepo
    {
        void CreateOne(Category category);

        IEnumerable<Category> GetAll(GetAllParams options);

        Category GetOne(Guid id);
        Category UpdateOne(Category category);
        bool DeleteOne(Guid id);
    }
}