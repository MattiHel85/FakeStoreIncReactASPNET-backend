using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Controller.src
{
    public class OrderItemController : BaseController<OrderItem, OrderItemReadDTO, OrderItemCreateDTO, OrderItemUpdateDTO>
    {
        public OrderItemController(IOrderItemService service) : base(service)
        {}
    }
}