using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Entity.User;

namespace FakeStoreInc.Business.src.DTO
{
    public class UserReadDTO : BaseEntity
    {
        public Role Role { get; set;}
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public IEnumerable<AddressReadDTO> Addresses { get; set; }

    }
    public class UserUpdateDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }

    // public class GetAllUserDTO
    // {
    //     public IEnumerable<UserReadDTO> UserReadDtos { get; set;}
    //     public int Pages { get; set; }
    // }
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