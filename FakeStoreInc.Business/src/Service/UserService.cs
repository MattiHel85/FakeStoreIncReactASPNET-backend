using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Business.src.Shared;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity.User;

namespace FakeStoreInc.Business.src.Service
{
    public class UserService : BaseService<User, UserReadDTO, UserCreateDTO, UserUpdateDTO>, IUserService
    {
        public UserService(IUserRepo repo, IMapper mapper) :base(repo, mapper)
        {
        
        }

        public Task<bool> UpdatePasswordAsync(string newPassword, Guid userId)
        {
            throw new NotImplementedException();
        }

        public override async Task<UserReadDTO> CreateOne(UserCreateDTO createObject)
        {
            PasswordService.HashPassword(createObject.Password, out string hashedPassword, out byte[] salt);
            var user = _mapper.Map<UserCreateDTO, User>(createObject);
            user.Password = hashedPassword;
            user.Salt = salt;
            return _mapper.Map<User, UserReadDTO>(await _repo.CreateOneAsync(user));

        }
    }
}