using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
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
       public virtual Task<bool> DeleteOneAsync(Guid id)
       {
            throw new NotImplementedException();
       }

       public virtual Task<IEnumerable<TReadDto>> GetAllAsync(GetAllOptions getAllOptions)
       {
            throw new NotImplementedException();
       }

       public virtual Task<TReadDto> GetByIdAsync(Guid id)
       {
            throw new NotImplementedException();
       }

       public virtual Task<bool> UpdateOneAsync(Guid id, TUpdateDto updateObject)
       {
            throw new NotImplementedException();
       }
    }
}