using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Business.src.Service
{
    public class OrderDetailService : IOrderDetailService
    {
        public Task<OrderDetailReadDTO> CreateOneAsync(OrderDetailCreateDTO createObject)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDetailReadDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailReadDTO> GetOneAsync(OrderDetailKey orderDetailKey)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOneAsync(OrderDetailUpdateDTO updateObject)
        {
            throw new NotImplementedException();
        }
    }
}