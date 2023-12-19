using FakeStoreInc.Core.src.Entity.User;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IUserRepo : IBaseRepo<User>
    {
        Task<User?> FindByEmailAsync(string Email);
    }
}