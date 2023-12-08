namespace FakeStoreInc.Core.src.Entity
{
    public class User : BaseEntity
    {
        public Role Role { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }

    public enum Role
    {
        Admin,
        Customer
    }
}