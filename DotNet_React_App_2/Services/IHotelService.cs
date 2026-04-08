using DotNet_React_App_2.Entities.DTOs;

namespace DotNet_React_App_2.Services
{
    public interface IHotelService
    {
        public Task<List<GetAllHotelsDto>> GetAllHotelsAsync();
        public Task<GetHotelByIdDto> GetHotelByIdAsync(int id);
        public Task<GetHotelByIdDto?> CreateHotel(CreateHotelDto dto);
        public Task<bool> UpdateHotelAsync(int id,UpdateHotelDto dto);
        public Task<bool> DeleteHotelAsync(int id);
    }
}
