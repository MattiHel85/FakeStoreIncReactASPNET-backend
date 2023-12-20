namespace FakeStoreInc.Core.src.Entity
{
    public class Address : BaseEntity
    {
        public int HouseNumber { get; set; }
        public string? Street { get; set; }
        public string? PostCode { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}