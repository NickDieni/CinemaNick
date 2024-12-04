using Microsoft.AspNetCore.Mvc;
using CinemaDataModels.Data;
using Microsoft.EntityFrameworkCore;
using CinemaDataModels.Models.Entities;
using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Repositories.IRepository;

namespace CinemaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        //Dependency injection
        public UsersController(IMapper mapper, IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }
        // CREATE User
        // POST: /api/users
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddUserRequestDto addUserRequestDto)
        {
            // Map DTO to Domain Model
            var userDomainModel = mapper.Map<User>(addUserRequestDto);

            await userRepository.CreateAsync(userDomainModel);

            // Map Domain model to DTO
            return Ok(mapper.Map<UserDto>(userDomainModel));
        }

        // GET User
        // GET: /api/users

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usersDomainModel = await userRepository.GetAllAsync();

            // Map Domain Model to DTO
            return Ok(mapper.Map<List<UserDto>>(usersDomainModel));
        }

        // Get User By Id
        // GET; /api/users/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var userDomainModel = await userRepository.GetByIdAsync(id);

            if (userDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO
            return Ok(mapper.Map<UserDto>(userDomainModel));
        }

        // Update User By Id
        // PUT: /api/users/{id}
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateUserRequestDto updateUserRequestDto)
        {
            // Map DTO to Domain Model
            var userDomainModel = mapper.Map<User>(updateUserRequestDto);

            userDomainModel = await userRepository.UpdateAsync(id, userDomainModel);

            if (userDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO

            return Ok(mapper.Map<UserDto>(userDomainModel));
        }

        // Delete User By Id
        // DELETE: /api/users/{id}
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedUserDomainModel = await userRepository.DeleteAsync(id);
            if (deletedUserDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<UserDto>(deletedUserDomainModel));

            // Map Domain Model to DTO

        }
    }
}
