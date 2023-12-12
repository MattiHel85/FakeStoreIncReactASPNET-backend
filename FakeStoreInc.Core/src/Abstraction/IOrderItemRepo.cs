using FakeStoreInc.Core.src.Entity.OrderItem;
using FakeStoreInc.Core.src.Parameter;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IOrderItemRepo
    {
        IEnumerable<OrderItem> GetAll(GetAllParams options);

        OrderItem GetOneById(Guid id);
        void CreateOne(OrderItem orderItem);
        OrderItem UpdateOne(OrderItem orderItem);
        bool DeleteOne(Guid id);
    }
}