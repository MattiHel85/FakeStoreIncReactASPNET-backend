using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IOrderDetailService
    {
        Task<IEnumerable<OrderDetailReadDTO>> GetAllAsync();
        Task<OrderDetailReadDTO> GetOneAsync(OrderDetailKey orderDetailKey);
        Task<bool> UpdateOneAsync(OrderDetailUpdateDTO updateObject);
        Task<bool> DeleteOneAsync(Guid id);
        Task<OrderDetailReadDTO> CreateOneAsync(OrderDetailCreateDTO createObject);
    }
}