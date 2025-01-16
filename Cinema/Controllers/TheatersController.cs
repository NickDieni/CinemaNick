using Microsoft.AspNetCore.Mvc;
using CinemaDataModels.Data;
using Microsoft.EntityFrameworkCore;
using CinemaDataModels.Models.Entities;
using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Repositories.IRepository;
using CinemaDataModels.Models.DTO.Sub_Theater;

namespace CinemaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatersController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ITheaterRepository theaterRepository;

        //Dependency injection
        public TheatersController(IMapper mapper, ITheaterRepository theaterRepository)
        {
            this.mapper = mapper;
            this.theaterRepository = theaterRepository;
        }
        // CREATE Theater
        // POST: /api/theaters
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddTheaterRequestDto addTheaterRequestDto)
        {
            // Map DTO to Domain Model
            var theaterDomainModel = mapper.Map<Theater>(addTheaterRequestDto);

            await theaterRepository.CreateAsync(theaterDomainModel);

            // Map Domain model to DTO
            return Ok(mapper.Map<TheaterDto>(theaterDomainModel));
        }

        // GET Theater
        // GET: /api/theaters

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var theaterDomainModel = await theaterRepository.GetAllAsync();

            // Map Domain Model to DTO
            return Ok(mapper.Map<List<TheaterDto>>(theaterDomainModel));
        }

        // Get Theater By Id
        // GET; /api/theaters/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var theaterDomainModel = await theaterRepository.GetByIdAsync(id);

            if (theaterDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO
            return Ok(mapper.Map<TheaterDto>(theaterDomainModel));
        }

        // Update Theater By Id
        // PUT: /api/theaters/{id}
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateTheaterRequestDto updateTheaterRequestDto)
        {
            // Map DTO to Domain Model
            var theaterDomainModel = mapper.Map<Theater>(updateTheaterRequestDto);

            theaterDomainModel = await theaterRepository.UpdateAsync(id, theaterDomainModel);

            if (theaterDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO

            return Ok(mapper.Map<TheaterDto>(theaterDomainModel));
        }

        // Delete Theater By Id
        // DELETE: /api/theaters/{id}
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedTheaterDomainModel = await theaterRepository.DeleteAsync(id);
            if (deletedTheaterDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<TheaterDto>(deletedTheaterDomainModel));

            // Map Domain Model to DTO

        }
    }
}
