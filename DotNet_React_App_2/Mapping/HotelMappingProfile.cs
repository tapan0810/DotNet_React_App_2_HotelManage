using AutoMapper;
using DotNet_React_App_2.Entities.DTOs;
using DotNet_React_App_2.Entities.Models;

namespace DotNet_React_App_2.Mapping
{
    public class HotelMappingProfile:Profile
    {
        public HotelMappingProfile()
        {
            CreateMap<Hotel, GetAllHotelsDto>();

            CreateMap<CreateHotelDto, Hotel>();

            CreateMap<CreateHotelDto,Hotel>();

            CreateMap<Hotel, GetHotelByIdDto>();

        }
    }
}
