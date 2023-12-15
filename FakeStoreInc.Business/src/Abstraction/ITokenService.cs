using FakeStoreInc.Core.src.Entity.User;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}