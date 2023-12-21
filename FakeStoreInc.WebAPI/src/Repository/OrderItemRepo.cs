using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.WebAPI.src.Database;

namespace FakeStoreInc.WebAPI.src.Repository
{
    public class OrderItemRepo :BaseRepo<OrderItem>, IOrderItemRepo
    {
        public OrderItemRepo(DatabaseContext databaseContext) :base(databaseContext)
        {}
    }
}