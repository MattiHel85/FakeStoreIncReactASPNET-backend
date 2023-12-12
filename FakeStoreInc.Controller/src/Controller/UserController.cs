using FakeStoreInc.Business.src.DTO;
using Microsoft.AspNetCore.Mvc;
using FakeStoreInc.Core.src.Parameter;
using FakeStoreInc.Business.src.Abstraction;

namespace FakeStoreInc.Controller.src.Controller
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<UserReadDTO>> GetAll([FromQuery] GetAllParams options)
        {
            return Ok(_userService.GetAll(options));
        }

        [HttpPost()]
        public ActionResult<UserReadDTO> CreateOne([FromQuery] UserCreateDTO userCreateDto)
        {
            return CreatedAtAction(nameof(CreateOne),_userService.CreateOne(userCreateDto));
        }
    }
}