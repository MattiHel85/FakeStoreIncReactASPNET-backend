using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IOrderItemRepo
    {
        IEnumerable<OrderItem> GetAll(GetAllOptions options);

        OrderItem GetOneById(Guid id);
        void CreateOne(OrderItem orderItem);
        OrderItem UpdateOne(OrderItem orderItem);
        bool DeleteOne(Guid id);
    }
}