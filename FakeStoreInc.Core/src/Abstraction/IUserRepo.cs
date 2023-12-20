using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IUserRepo : IBaseRepo<User>
    {
        Task<User?> FindByEmailAsync(string Email);
    }
}