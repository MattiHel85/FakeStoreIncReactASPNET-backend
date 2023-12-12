using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Parameter;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IUserService
    {
        IEnumerable<UserReadDTO> GetAll(GetAllParams options);
        UserReadDTO GetOneById(Guid id);
        UserReadDTO CreateOne(UserCreateDTO userCreateDto);
        UserReadDTO UpdateOne(UserUpdateDTO userUpdateDto);
        bool DeleteOne(Guid id);
    }
}