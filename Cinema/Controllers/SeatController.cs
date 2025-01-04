using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using CinemaDataModels.Models.DTO.Sub_Seat;

namespace CinemaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : Controller
    {
        private readonly IMapper mapper;
        private readonly ISeatRepository seatRepository;

        //Dependency injection
        public SeatController(IMapper mapper, ISeatRepository seatRepository)
        {
            this.mapper = mapper;
            this.seatRepository = seatRepository;
        }
        // CREATE User
        // POST: /api/users
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddSeatRequestDto addSeatRequestDto)
        {
            // Map DTO to Domain Model
            var seatDomainModel = mapper.Map<Seat>(addSeatRequestDto);

            await seatRepository.CreateAsync(seatDomainModel);

            // Map Domain model to DTO
            return Ok(mapper.Map<SeatDto>(seatDomainModel));
        }

        // GET User
        // GET: /api/users

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var seatDomainModel = await seatRepository.GetAllAsync();

            // Map Domain Model to DTO
            return Ok(mapper.Map<List<SeatDto>>(seatDomainModel));
        }

        // Get User By Id
        // GET; /api/users/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var seatDomainModel = await seatRepository.GetByIdAsync(id);

            if (seatDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO
            return Ok(mapper.Map<SeatDto>(seatDomainModel));
        }

        // Delete User By Id
        // DELETE: /api/users/{id}
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedSeatDomainModel = await seatRepository.DeleteAsync(id);
            if (deletedSeatDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<SeatDto>(deletedSeatDomainModel));

            // Map Domain Model to DTO

        }
    }
}
