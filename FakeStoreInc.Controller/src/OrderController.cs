using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Controller.src
{
    public class OrderController : BaseController<Order, OrderReadDTO, OrderCreateDTO, OrderUpdateDTO>
    {
        public OrderController(IOrderService service) : base(service)
        {}
    }
}