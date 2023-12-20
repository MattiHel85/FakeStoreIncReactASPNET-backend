using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Business.src.Service
{
    public class BaseService<T, TReadDto, TCreateDto, TUpdateDto> : IBaseService<T, TReadDto, TCreateDto, TUpdateDto>
    where T : BaseEntity
    {
        protected readonly IBaseRepo<T> _repo;
        protected readonly IMapper _mapper;

        public BaseService(IBaseRepo<T> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
       public virtual async Task<TReadDto> CreateOneAsync(TCreateDto createObject)
       {
            return _mapper.Map<T, TReadDto>(await _repo.CreateOneAsync(_mapper.Map<TCreateDto, T>(createObject)));
       }
       public virtual async Task<bool> DeleteOneAsync(Guid id)
       {
            var entity = await _repo.GetByIdAsync(id);
            if(entity == null)
            {
               return false;
            }
            return await _repo.DeleteOneAsync(entity);
       }

       public virtual async Task<IEnumerable<TReadDto>> GetAllAsync(GetAllOptions getAllOptions)
       {
          var result = await _repo.GetAllAsync(getAllOptions);
          return _mapper.Map<IEnumerable<T>, IEnumerable<TReadDto>>(result);
       }

       public virtual async Task<TReadDto> GetByIdAsync(Guid id)
       {
            var entity = await _repo.GetByIdAsync(id);
            return _mapper.Map<T?, TReadDto>(entity);
       }

       public virtual async Task<bool> UpdateOneAsync(Guid id, TUpdateDto updateObject)
       {
            var entity = await _repo.GetByIdAsync(id);
            if(entity == null)
            {
               return false;
            }

            _mapper.Map(updateObject, entity);
            return await _repo.UpdateOneAsync(entity);
       }
    }
}