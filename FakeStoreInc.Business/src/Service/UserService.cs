using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Business.src.Shared;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Business.src.Service
{
    public class UserService : BaseService<User, UserReadDTO, UserCreateDTO, UserUpdateDTO>, IUserService
    {
        public UserService(IUserRepo repo, IMapper mapper) :base(repo, mapper)
        {
        
        }

        public async Task<bool> UpdatePasswordAsync(string newPassword, Guid userId)
        {
            var user = await _repo.GetByIdAsync(userId);
            if(user is null)
            {
                throw new Exception();
            }
            PasswordService.HashPassword(newPassword, out string hashedPassword, out byte[] salt);
            user.Password = hashedPassword;
            user.Salt = salt;
            return await _repo.UpdateOneAsync(user);
        }

        public override async Task<UserReadDTO> CreateOneAsync(UserCreateDTO createObject)
        {            
            PasswordService.HashPassword(createObject.Password, out string hashedPassword, out byte[] salt);
            var user = _mapper.Map<UserCreateDTO, User>(createObject);
            user.Password = hashedPassword;
            user.Salt = salt;
            return _mapper.Map<User?, UserReadDTO>(await _repo.CreateOneAsync(user));
        }
    }
}