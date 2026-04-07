namespace DotNet_React_App_2.Entities.DTOs
{
    public class GetHotelByIdDto
    {
        public int Id { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
