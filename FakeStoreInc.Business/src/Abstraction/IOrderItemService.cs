using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IOrderItemService :IBaseService<OrderItem, OrderItemReadDTO, OrderItemCreateDTO, OrderItemUpdateDTO>
    {}
}