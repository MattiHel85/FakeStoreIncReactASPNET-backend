using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IAuthService
    {
        Task<string> Login(Credentials credentials);
    }
}