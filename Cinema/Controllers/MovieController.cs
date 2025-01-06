using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMovieRepository movieRepository;

        public MoviesController(IMapper mapper, IMovieRepository movieRepository)
        {
            this.mapper = mapper;
            this.movieRepository = movieRepository;
        }
        // CREATE Movie
        // POST: /api/movie
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddMovieRequestDto addMovieRequestDto)
        {
            // Create the movie using the repository
            var movieDomainModel = await movieRepository.CreateAsync(addMovieRequestDto);

            // Map Domain model to DTO
            var movieDto = mapper.Map<MovieDto>(movieDomainModel);

            return Ok(movieDto);
        }


        // GET Movie
        // GET: /api/movie

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var moviesDomainModel = await movieRepository.GetAllAsync();

            // Map Domain Model to DTO
            return Ok(mapper.Map<List<MovieDto>>(moviesDomainModel));
        }

        // Get Movie By Id
        // GET; /api/movies/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var movieDomainModel = await movieRepository.GetByIdAsync(id);

            if (movieDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO
            return Ok(mapper.Map<MovieDto>(movieDomainModel));
        }

        // Update Movie By Id
        // PUT: /api/movies/{id}
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateMovieRequestDto updateMovieRequestDto)
        {
            // Map DTO to Domain Model
            var movieDomainModel = mapper.Map<Movie>(updateMovieRequestDto);

            movieDomainModel = await movieRepository.UpdateAsync(id, movieDomainModel);

            if (movieDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO

            return Ok(mapper.Map<MovieDto>(movieDomainModel));
        }

        // Delete Movie By Id
        // DELETE: /api/movie/{id}
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedMovieDomainModel = await movieRepository.DeleteAsync(id);
            if (deletedMovieDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<MovieDto>(deletedMovieDomainModel));

            // Map Domain Model to DTO

        }
    }
}
