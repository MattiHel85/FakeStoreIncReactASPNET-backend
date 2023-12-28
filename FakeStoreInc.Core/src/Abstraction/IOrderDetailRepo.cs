using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IOrderDetailRepo 
    {
        Task<IEnumerable<OrderDetail>>? GetAllAsync();
        Task<OrderDetail> GetOneAsync(OrderDetailKey orderDetailKey);
        Task<bool> UpdateOneAsync(OrderDetail updateObject);
        Task<bool> DeleteOneAsync(OrderDetail DeleteObject);
        Task<OrderDetail> CreateOneAsync(OrderDetail createObject);
    }
}