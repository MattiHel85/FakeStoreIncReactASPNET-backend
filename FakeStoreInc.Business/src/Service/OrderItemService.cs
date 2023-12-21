using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Service
{
    public class OrderItemService : BaseService<OrderItem, OrderItemReadDTO, OrderItemCreateDTO, OrderItemUpdateDTO>, IOrderItemService
    {
        public OrderItemService(IOrderItemRepo repo, IMapper mapper) : base(repo, mapper)
        {}
    }
}