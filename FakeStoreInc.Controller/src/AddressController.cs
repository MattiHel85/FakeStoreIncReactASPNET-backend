using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Controller.src
{
    public class AddressController : BaseController<Address, AddressReadDTO, AddressCreateDTO, AddressUpdateDTO>
    {
        public AddressController(IAddressService service) : base (service)
        {}
    }
}