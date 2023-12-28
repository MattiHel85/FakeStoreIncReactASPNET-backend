namespace FakeStoreInc.Core.src.Entity
{
    public class TimeStamp
    {
        public int Id { get; set; } 
        public DateTime CreatedDate {get; set;} = DateTime.UtcNow;
        public DateTime UpdatedDate {get; set;}
    }
}