using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IOrderRepo
    {
        void CreateOne(Order order);

        IEnumerable<Order> GetAll(GetAllParams options);

        Order GetOne(Guid id);
        Order UpdateOne(Order order);
        bool DeleteOne(Guid id);
    }
}