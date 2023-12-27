using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;
using FakeStoreInc.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace FakeStoreInc.WebAPI.src.Repository
{
    public class OrderDetailRepo : IOrderDetailRepo
    {
        protected readonly DbSet<OrderDetail> _data;
        protected readonly DatabaseContext _databaseContext;
        public OrderDetailRepo(DatabaseContext context)
        {
            _databaseContext = context;
            _data = _databaseContext.OrderDetails;
        }
        public Task<OrderDetail> CreateOneAsync(OrderDetail createObject)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneAsync(OrderDetail DeleteObject)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDetail>>? GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetail> GetOneAsync(OrderDetailKey orderDetailKey)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOneAsync(OrderDetail updateObject)
        {
            throw new NotImplementedException();
        }
    }
}