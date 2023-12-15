using FakeStoreInc.Core.src.Shared;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IBaseService<T, TReadDto, TCreateDto, TUpdateDto> where T: BaseEntity
    {
        Task<IEnumerable<TReadDto>> GetAllAsync(GetAllOptions getAllOptions);
        Task<TReadDto> GetByIdAsync(Guid id);
        Task<bool> UpdateOneAsync(Guid id, TUpdateDto updateObject);
        Task<bool> DeleteOneAsync(Guid id);
        Task<TReadDto> CreateOne(TCreateDto createObject);
    }
}