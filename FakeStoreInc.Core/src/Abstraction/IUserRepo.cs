using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IUserRepo
    {
        User CreateOne(User user);
        IEnumerable<User> GetAll(GetAllParams options);
        User GetOne(Guid id);
        User UpdateOne(User user);
        bool DeleteOne(Guid id);
    }
}