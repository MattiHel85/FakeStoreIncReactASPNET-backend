using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.WebAPI.src.Database;

namespace FakeStoreInc.WebAPI.src.Repository
{
    public class AddressRepo : BaseRepo<Address>, IAddressRepo
    {
        public AddressRepo(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}