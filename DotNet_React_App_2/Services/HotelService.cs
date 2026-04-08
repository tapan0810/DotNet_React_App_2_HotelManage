using AutoMapper;
using DotNet_React_App_2.Data;
using DotNet_React_App_2.Entities.DTOs;
using DotNet_React_App_2.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_React_App_2.Services
{
    public class HotelService (HotelDbContext _context,IMapper _mapper): IHotelService
    {
        public async Task<GetHotelByIdDto?> CreateHotel(CreateHotelDto dto)
        {
            var hotel = _mapper.Map<Hotel>(dto);
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();

            return _mapper.Map<GetHotelByIdDto>(hotel);
        }

        public async Task<bool> DeleteHotelAsync(int id)
        {
            var hotel = await _context.Hotels.FirstOrDefaultAsync(X => X.Id == id);

            if(hotel is null)
                return false;

            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<GetAllHotelsDto>> GetAllHotelsAsync()
        {
            var hotel = await _context.Hotels.ToListAsync();
            return _mapper.Map<List<GetAllHotelsDto>>(hotel);
        }

        public async Task<GetHotelByIdDto> GetHotelByIdAsync(int id)
        {
            var hotel = await _context.Hotels.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<GetHotelByIdDto>(hotel);
        }

        public async Task<bool> UpdateHotelAsync(int id, UpdateHotelDto dto)
        {
            var hotel = await _context.Hotels.FirstOrDefaultAsync(x => x.Id == id);
            if (hotel is null)
                return false;

            _mapper.Map(dto, hotel);

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
