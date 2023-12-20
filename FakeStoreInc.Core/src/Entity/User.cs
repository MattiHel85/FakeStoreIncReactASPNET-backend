using System.Dynamic;
using System.Text.Json.Serialization;
using FakeStoreInc.Core.src.Shared;

namespace FakeStoreInc.Core.src.Entity
{
    public class User : BaseEntity
    {
        public Role Role { get; set;}
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public byte[]? Salt { get; set; } // Random key for hashing passwords
        public IEnumerable<Address>? Addresses { get; set; }
        public ICollection<Order>? Orders { get; set;}
        
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        Admin,
        Customer
    }
}