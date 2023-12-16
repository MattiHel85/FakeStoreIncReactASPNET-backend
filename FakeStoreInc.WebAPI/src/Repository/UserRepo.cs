using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity.User;
using FakeStoreInc.Core.src.Shared;
using FakeStoreInc.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace FakeStoreInc.WebAPI.src.Repository
{
    public class UserRepo : IUserRepo
    {
        private DbSet<User> _users;
        private DatabaseContext _database;

        public UserRepo(DatabaseContext database)
        {
            _users = database.Users;
            _database = database;

        }
        public User CreateOneAsync(User user)
        {
            _users.Add(user);
            _database.SaveChanges();
            return user;
        }
        public bool DeleteOneAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetAllAsync(GetAllOptions options)
        {
            return _users.Where(u => u.FirstName.Contains(options.Search)).Skip(options.Offset).Take(options.Limit);
        }
        public User GetOneByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public User UpdateOneAsync(User user)
        {
            throw new NotImplementedException();
        }
        public User UpdatePasswordAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}