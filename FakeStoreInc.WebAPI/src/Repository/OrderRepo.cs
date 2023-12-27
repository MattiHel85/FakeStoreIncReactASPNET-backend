using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace FakeStoreInc.WebAPI.src.Repository
{
    public class OrderRepo :BaseRepo<Order>, IOrderRepo
    {
        private readonly DbSet<OrderDetail> _orderDetails;
        public OrderRepo(DatabaseContext databaseContext) :base(databaseContext)
        {
            _orderDetails = _databaseContext.OrderDetails;
        }

        public override async Task<Order> CreateOneAsync(Order createObject)
        {
            using ( var transaction = await _databaseContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var order = new Order{User = createObject.User};

                    foreach( var detail in createObject.OrderDetails)
                    {
                        // detail.Quantity
                        // detail.Product.StockQuantity
                    }
                    return order;
                }
                catch ( Exception e)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
            // return base.CreateOneAsync(createObject);
        }
    }
}