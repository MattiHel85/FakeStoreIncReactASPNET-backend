using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class UserReadDTO : BaseEntity
    {
        public Role Role { get; set;}
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public IEnumerable<AddressReadDTO>? Addresses { get; set; }

    }
    public class UserUpdateDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public IEnumerable<AddressUpdateDTO>? Addresses { get; set;}
    }
    public class UserCreateDTO
    {
        public Role Role { get; set;} = Role.Customer;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public IEnumerable<AddressCreateDTO>? Addresses { get; set; }
    }
}