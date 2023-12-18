using AutoMapper;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Entity.User;

namespace FakeStoreInc.Business.src.Shared
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<User, UserReadDTO>().ForMember(dest => dest.FirstName, option => option.MapFrom(source => source.FirstName.ToLower()));
            CreateMap<User, UserReadDTO>();
            CreateMap<UserUpdateDTO, User>();
            CreateMap<UserCreateDTO, User>();
            
            CreateMap<Address, AddressReadDTO>();
        }
    }
}