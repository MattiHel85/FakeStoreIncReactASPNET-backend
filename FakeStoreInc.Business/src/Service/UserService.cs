using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Parameter;
using FakeStoreInc.Core.src.Entity.User;

namespace FakeStoreInc.Business.src.Service
{
    public class UserService : IUserService
    {
        private IUserRepo _userRepo;
        private IMapper _mapper;

        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public UserReadDTO CreateOne(UserCreateDTO userCreateDto)
        {
            var result = _userRepo.CreateOne(_mapper.Map<UserCreateDTO, User>(userCreateDto));
            // var result = _use;
            // var userReadDto = new UserReadDTO();
            // return userReadDto.Convert(result);
            return _mapper.Map<User, UserReadDTO>(result);
        }
        public bool DeleteOne(Guid id)
        {
            var deletedSuccessfully = _userRepo.DeleteOne(id);
            return deletedSuccessfully;
        }

        public IEnumerable<UserReadDTO> GetAll(GetAllParams options)
        {
            // return _userRepo.GetAll(options).Select(u => new UserReadDTO().Convert(u));
            var result = _userRepo.GetAll(options);
            return _mapper.Map<IEnumerable<User>,IEnumerable<UserReadDTO>>(result);
        }

        public UserReadDTO GetOneById(Guid id)
        {
            throw new NotImplementedException();
            // var user = _userRepo.GetOneById(id);

            // if (user == null)
            // {
            //     throw new NotImplementedException($"User with ID {id} not found");
            // }

            // var userReadDto = new UserReadDTO();
            // return userReadDto.Convert(user);
        }

        public UserReadDTO UpdateOne(UserUpdateDTO userUpdateDto)
        {
            throw new NotImplementedException();
            // var result = _userRepo.UpdateOne(userUpdateDto.Transform());
            // var userReadDto = new UserReadDTO();
            // return userReadDto.Convert(result);
        }

    }
}