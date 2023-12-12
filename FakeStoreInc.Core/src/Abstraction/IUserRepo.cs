using FakeStoreInc.Core.src.Entity.User;
using FakeStoreInc.Core.src.Parameter;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAll(GetAllParams options);
        User GetOneById(Guid id);
        User CreateOne(User user);
        User UpdateOne(User user);
        bool DeleteOne(Guid id);
    }
}