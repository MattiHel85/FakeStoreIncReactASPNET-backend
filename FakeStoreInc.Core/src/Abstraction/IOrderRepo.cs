using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IOrderRepo
    {

        IEnumerable<Order> GetAll(GetAllOptions options);

        Order GetOneById(Guid id);
        Order CreateOne(Order order);
        Order UpdateOne(Order order);
        bool DeleteOne(Guid id);
    }
}