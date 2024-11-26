using Microsoft.AspNetCore.Mvc;
using CinemaDataModels.Data;
using Microsoft.EntityFrameworkCore;
using CinemaDataModels.Models.Entities;

namespace CinemaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CinemaContext dbContext;
        public UsersController(CinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSync()
        {
            var users = await dbContext.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<User> GetById(int id)
        {
            return await dbContext.Users.FindAsync(id);
        }
        [HttpPost]
        public async Task<User> Create(User user)
        {
            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync();
            return user;
        }
        [HttpPut]
        public async Task<User> Update(User user)
        {
            dbContext.Users.Update(user);
            await dbContext.SaveChangesAsync();
            return user;
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var user = await dbContext.Users.FindAsync(id);
            dbContext.Users.Remove(user);
            await dbContext.SaveChangesAsync();
        }
    }
}
