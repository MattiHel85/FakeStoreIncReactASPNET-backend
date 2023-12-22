using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;
using FakeStoreInc.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace FakeStoreInc.WebAPI.src.Repository
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        public UserRepo(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            return await _data.AsNoTracking().FirstOrDefaultAsync(u => u.Email == email);
        }

        public override async Task<IEnumerable<User>> GetAllAsync(GetAllOptions options)
        {
          var result = await _data
            .Include(u => u.Addresses)
            .OrderBy(entity => entity.Id)
            .Skip(options.Offset)
            .Take(options.Limit)
            .ToArrayAsync();
          return result;
        }

        // public Task<bool> UpdatePasswordAsync(string newPassword, Guid userId)
        // {
        //     throw new NotImplementedException();
        // }
    }
}