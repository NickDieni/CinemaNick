using AutoMapper;
using CinemaDataModels.Models.DTO.Sub_Seat;
using CinemaDataModels.Models.DTO.Sub_Showtime;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTimeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IShowtimeRepository showTimeRepository;

        //Dependency injection
        public ShowTimeController(IMapper mapper, IShowtimeRepository showTimeRepository)
        {
            this.mapper = mapper;
            this.showTimeRepository = showTimeRepository;
        }
        // CREATE User
        // POST: /api/users
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddShowTimeRequestDto addshowtimeRequestDto)
        {
            // Map DTO to Domain Model
            var showtimeDomainModel = mapper.Map<Showtime>(addshowtimeRequestDto);

            await showTimeRepository.CreateAsync(showtimeDomainModel);

            // Map Domain model to DTO
            return Ok(mapper.Map<ShowtimeDto>(showtimeDomainModel));
        }

        // GET User
        // GET: /api/users

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var showtimeDomainModel = await showTimeRepository.GetAllAsync();

            // Map Domain Model to DTO
            return Ok(mapper.Map<List<ShowtimeDto>>(showtimeDomainModel));
        }

        // Get User By Id
        // GET; /api/users/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var showtimeDomainModel = await showTimeRepository.GetByIdAsync(id);

            if (showtimeDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO
            return Ok(mapper.Map<ShowtimeDto>(showtimeDomainModel));
        }

        // Delete User By Id
        // DELETE: /api/users/{id}
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedShowtimeDomainModel = await showTimeRepository.DeleteAsync(id);
            if (deletedShowtimeDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<ShowtimeDto>(deletedShowtimeDomainModel));

            // Map Domain Model to DTO

        }
    }
}
