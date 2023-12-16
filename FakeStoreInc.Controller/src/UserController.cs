using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity.User;

namespace FakeStoreInc.Controller.src
{
    public class UserController : BaseController<User, UserReadDTO, UserCreateDTO, UserUpdateDTO>
    {
        public UserController(IUserService service) : base(service)
        {
        }
    }
}