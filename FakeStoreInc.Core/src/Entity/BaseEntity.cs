namespace FakeStoreInc.Core.src.Entity
{
    public class BaseEntity
    {
        public Guid Id { get; set;}
        public DateTime CreatedDate {get; set;} = DateTime.UtcNow;
        public DateTime UpdatedDate {get; set;}
    }
}