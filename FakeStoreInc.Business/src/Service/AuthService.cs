using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.Shared;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Business.src.Service
{
    public class AuthService : IAuthService
    {
        private IUserRepo _repo;
        public AuthService(IUserRepo userRepo)
        {
            _repo = userRepo;
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
                return "";
            }
            throw new Exception("Not found");
        }
    }
}