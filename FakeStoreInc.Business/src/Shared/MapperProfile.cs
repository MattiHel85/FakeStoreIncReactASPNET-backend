using AutoMapper;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Business.src.DTO.FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Shared
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserReadDTO>();
            CreateMap<UserCreateDTO, User>();
            CreateMap<UserUpdateDTO, User>().ForAllMembers(opt => opt.Condition((src, dest, value) => value != null));
            
            CreateMap<Address, AddressReadDTO>();
            CreateMap<AddressCreateDTO, Address>();
            CreateMap<AddressUpdateDTO, Address>().ForAllMembers(opt => opt.Condition((src, dest, value) => value != null));

            CreateMap<Product, ProductReadDTO>();
            CreateMap<ProductCreateDTO, Product>();
            CreateMap<ProductUpdateDTO, Product>().ForAllMembers(opt => opt.Condition((src, dest, value) => value != null));

            CreateMap<Category, CategoryReadDTO>();
            CreateMap<CategoryCreateDTO, Category>();
            CreateMap<CategoryUpdateDTO, Category>().ForAllMembers(opt => opt.Condition((src, dest, value) => value != null));
            
            CreateMap<Order, OrderReadDTO>();
            CreateMap<OrderCreateDTO, Order>();
            CreateMap<OrderUpdateDTO, Order>().ForAllMembers(opt => opt.Condition((src, dest, value) => value != null));
            
            CreateMap<OrderItem, OrderItemReadDTO>();
            CreateMap<OrderItemCreateDTO, OrderItem>();
            CreateMap<OrderItemUpdateDTO, OrderItem>().ForAllMembers(opt => opt.Condition((src, dest, value) => value != null));
        }
    }
}