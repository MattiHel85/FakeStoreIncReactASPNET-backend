using FakeStoreInc.Core.src.Entity.User;

namespace FakeStoreInc.Business.src.DTO
{
    public class UserReadDTO
    {
        public Role Role { get; set;}
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

    }
    public class UserUpdateDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
    public class UserCreateDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}