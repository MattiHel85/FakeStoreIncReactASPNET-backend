using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Service
{
    public class OrderService : BaseService<Order, OrderReadDTO, OrderCreateDTO, OrderUpdateDTO>, IOrderService
    {
        public OrderService(IOrderRepo repo, IMapper mapper) : base(repo, mapper)
        {

        }
    }
}