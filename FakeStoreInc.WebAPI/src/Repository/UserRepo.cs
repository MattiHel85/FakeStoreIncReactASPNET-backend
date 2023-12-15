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
        public User CreateOne(User user)
        {
            _users.Add(user);
            _database.SaveChanges();
            return user;
        }
        public bool DeleteOne(Guid id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetAll(GetAllOptions options)
        {
            return _users.Where(u => u.FirstName.Contains(options.Search)).Skip(options.Offset).Take(options.Limit);
        }
        public User GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }
        public User UpdateOne(User user)
        {
            throw new NotImplementedException();
        }
    }
}