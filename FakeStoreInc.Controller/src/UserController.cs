using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FakeStoreInc.Controller.src
{
    public class UserController : BaseController<User, UserReadDTO, UserCreateDTO, UserUpdateDTO>
    {
        private readonly IUserService _userService;

        public UserController(IUserService service) : base(service)
        {
            _userService = service;
        }

        // [Authorize(Roles = "Admin")]
        [HttpGet()]
        public override async Task<ActionResult<IEnumerable<UserReadDTO>>> GetAllAsync([FromQuery] GetAllOptions getAllOptions)
        {
            return Ok(await _userService.GetAllAsync(getAllOptions));
        }
    }
}
