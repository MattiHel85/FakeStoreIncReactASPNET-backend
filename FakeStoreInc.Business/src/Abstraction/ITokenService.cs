using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}