using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Core.src.Abstraction
{
    public interface IBaseRepo<T> where T:BaseEntity
    {
        Task<IEnumerable<T>>? GetAllAsync(GetAllOptions getAllOptions);
        Task<T?> GetByIdAsync(Guid id);
        Task<bool> UpdateOneAsync(T updateObject);
        Task<bool> DeleteOneAsync(T DeleteObject);
        Task<T?> CreateOneAsync(T createObject);
    }
}