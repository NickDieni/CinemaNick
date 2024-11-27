using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IGenreRepository genreRepository;

        public GenresController(IMapper mapper, IGenreRepository genreRepository)
        {
            this.mapper = mapper;
            this.genreRepository = genreRepository;
        }

        // GET Genre
        // GET: /api/genres

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var genreDomainModel = await genreRepository.GetAllAsync();

            // Map Domain Model to DTO
            return Ok(mapper.Map<List<GenreDto>>(genreDomainModel));
        }

        // Get Genre By Id
        // GET; /api/genres/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var genreDomainModel = await genreRepository.GetByIdAsync(id);

            if (genreDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO
            return Ok(mapper.Map<GenreDto>(genreDomainModel));
        }
    }
}
