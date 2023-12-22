using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Core.src.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FakeStoreInc.Controller.src
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private IAuthService _service;
        public AuthController(IAuthService service)
        {
            _service = service;
        }
        [HttpPost()]
        public async Task<string> Login(Credentials cred)
        {
            return await _service.Login(cred);
        }
    }
}