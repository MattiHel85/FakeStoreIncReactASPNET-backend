using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;
using FakeStoreInc.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace FakeStoreInc.WebAPI.src.Repository
{
    public class BaseRepo<T> : IBaseRepo<T> where T : BaseEntity
    {
        protected readonly DbSet<T> _data;
        protected readonly DatabaseContext _databaseContext;
        public BaseRepo(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _data = _databaseContext.Set<T>();
        }
        public async Task<T> CreateOneAsync(T createObject)
        {
            await _data.AddAsync(createObject);
            await _databaseContext.SaveChangesAsync();
            return createObject;
        }

        public async Task<bool> DeleteOneAsync(T DeleteObject)
        {
            var existingEntity = await _data.FindAsync(DeleteObject.Id);

            if (existingEntity == null)
            {
                return false;
            }

            // var addresses = await _addressRepo.GetAddressesByUserIdAsync(userId);
            // foreach (var address in addresses)
            // {
            //     await _addressRepo.DeleteOneAsync(address);
            // }

            _data.Remove(existingEntity);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync(GetAllOptions getAllOptions)
        {
            return  await _data.AsNoTracking().Skip(getAllOptions.Offset).Take(getAllOptions.Limit).ToArrayAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _data.FindAsync(id);
        }

        public async Task<bool> UpdateOneAsync(T updateObject)
        {
            var existingEntity = await _data.FindAsync(updateObject.Id);
            
            if (existingEntity == null)
            {
                return false;
            }
            _data.Update(existingEntity);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}