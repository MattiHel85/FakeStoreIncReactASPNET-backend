using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IAddressService : IBaseService<Address, AddressReadDTO, AddressCreateDTO, AddressUpdateDTO>
    {
        
    }
}