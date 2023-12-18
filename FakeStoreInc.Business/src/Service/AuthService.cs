using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.Shared;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Business.src.Service
{
    public class AuthService : IAuthService
    {
        private IUserRepo _repo;
        private ITokenService _tokenService;
        public AuthService(IUserRepo userRepo, ITokenService tokenService)
        {
            _repo = userRepo;
            _tokenService = tokenService;
        }
        public async Task<string> Login(Credentials credentials)
        {
            var foundByEmail = await _repo.FindByEmailAsync(credentials.Email);
            if(foundByEmail is null)
            {
                throw new Exception("Email not found");
            }

            var isPasswordMatch = PasswordService.VerifyPassword(credentials.Password, foundByEmail.Password, foundByEmail.Salt);
            if(isPasswordMatch)
            {
                return _tokenService.GenerateToken(foundByEmail);
            }
            throw new Exception("Not found");
        }
    }
}