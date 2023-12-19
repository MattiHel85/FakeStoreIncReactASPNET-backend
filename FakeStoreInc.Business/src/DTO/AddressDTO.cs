namespace FakeStoreInc.Business.src.DTO
{
    public class AddressReadDTO
    {
        public int HouseNumber { get; set; }
        public string? Street { get; set; }
        public string? PostCode { get; set; }
    }
    public class AddressCreateDTO
    {
        public int HouseNumber { get; set; }
        public string? Street { get; set; }
        public string? PostCode { get; set; }
    }
    public class AddressUpdateDTO
    {
        public int HouseNumber { get; set; }
        public string? Street { get; set; }
        public string? PostCode { get; set; }
    }
}