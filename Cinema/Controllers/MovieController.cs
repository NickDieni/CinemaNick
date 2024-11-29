using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBackEnd.Controllers
{
    public class MovieController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMovieRepository movieRepository;

        public MovieController(IMapper mapper, IMovieRepository movieRepository)
        {
            this.mapper = mapper;
            this.movieRepository = movieRepository;
        }
        // CREATE User
        // POST: /api/users
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddUserRequestDto addUserRequestDto)
        {
            // Map DTO to Domain Model
            var movieDomainModel = mapper.Map<Movie>(addUserRequestDto);

            await movieRepository.CreateAsync(movieDomainModel);

            // Map Domain model to DTO
            return Ok(mapper.Map<MovieDto>(movieDomainModel));
        }

        // GET User
        // GET: /api/users

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var moviesDomainModel = await movieRepository.GetAllAsync();

            // Map Domain Model to DTO
            return Ok(mapper.Map<List<UserDto>>(moviesDomainModel));
        }

        // Get User By Id
        // GET; /api/users/{id}
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

        // Update User By Id
        // PUT: /api/users/{id}
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

        // Delete User By Id
        // DELETE: /api/users/{id}
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
