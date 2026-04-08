using DotNet_React_App_2.Entities.DTOs;
using DotNet_React_App_2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_React_App_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController(IHotelService _service) : ControllerBase
    {
        [HttpGet("GetAllHotels")]
        public async Task<ActionResult<List<GetAllHotelsDto>>> GetAllHotels()
        {
            var hotels = await _service.GetAllHotelsAsync();

            if (hotels == null || hotels.Count == 0)
            {
                return NotFound("No hotels found.");
            }

            return Ok(hotels);

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GetHotelByIdDto>> GetHotelById(int id)
        {
            var hotel = await _service.GetHotelByIdAsync(id);

            if (hotel is null)
                return NotFound($"Hotel with id {id} not found.");

            return Ok(hotel);
        }

        [HttpPost("CreateHotel")]
        public async Task<ActionResult<GetHotelByIdDto>> CreateHotel(CreateHotelDto dto)
        {
            var createdHotel = await _service.CreateHotel(dto);
            if (createdHotel is null)
                return BadRequest("Failed to create hotel.");
            return CreatedAtAction(nameof(GetHotelById), new { id = createdHotel.Id }, createdHotel);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateHotel(int id, UpdateHotelDto dto)
        {
            var isUpdated = await _service.UpdateHotelAsync(id, dto);
            if (!isUpdated)
                return NotFound($"Hotel with id {id} not found.");
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteHotel(int id)
        {
            var isDeleted = await _service.DeleteHotelAsync(id);
            if (!isDeleted)
                return NotFound($"Hotel with id {id} not found.");
            return NoContent();

        }
    }

    }
