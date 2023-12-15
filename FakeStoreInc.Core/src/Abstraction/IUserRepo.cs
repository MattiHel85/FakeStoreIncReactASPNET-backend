using FakeStoreInc.Core.src.Entity.User;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IUserRepo : IBaseRepo<User>
    {
        Task<bool> UpdatePasswordAsync(string newPassword, Guid userId);
        Task<User?> FindByEmailAsync(string Email);
    }
}