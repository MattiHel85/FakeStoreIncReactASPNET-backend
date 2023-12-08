using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IOrderItemRepo
    {
        void CreateOne(OrderItem orderItem);

        IEnumerable<OrderItem> GetAll(GetAllParams options);

        OrderItem GetOne(Guid id);
        OrderItem UpdateOne(OrderItem orderItem);
        bool DeleteOne(Guid id);
    }
}