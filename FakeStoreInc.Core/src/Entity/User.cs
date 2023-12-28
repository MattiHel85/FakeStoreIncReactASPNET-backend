using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FakeStoreInc.Core.src.Entity
{
    public class User : BaseEntity
    {
        public Role Role { get; set;}
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [MinLength(8), MaxLength(20)]
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