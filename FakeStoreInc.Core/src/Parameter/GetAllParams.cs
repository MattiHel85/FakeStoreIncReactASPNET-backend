namespace FakeStoreInc.Core.src.Parameter
{
    public class GetAllParams
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public string? Search { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
    }
}