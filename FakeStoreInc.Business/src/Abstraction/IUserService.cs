using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IUserService : IBaseService<User, UserReadDTO, UserCreateDTO, UserUpdateDTO>
    {
        Task<bool> UpdatePasswordAsync(string newPassword, Guid userId);
    }
}