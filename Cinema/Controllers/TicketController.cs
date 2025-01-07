using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Models.DTO.Sub_Ticket;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBackEnd.Controllers
{
    public class TicketController : Controller
    {
        private readonly IMapper mapper;
        private readonly ITicketRepository ticketRepository;

        //Dependency injection
        public TicketController(IMapper mapper, ITicketRepository ticketRepository)
        {
            this.mapper = mapper;
            this.ticketRepository = ticketRepository;
        }
        // CREATE User
        // POST: /api/ticket
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddTicketRequestDto addTicketRequestDto)
        {
            // Map DTO to Domain Model
            var ticketDomainModel = mapper.Map<Ticket>(addTicketRequestDto);

            await ticketRepository.CreateAsync(ticketDomainModel);

            // Map Domain model to DTO
            return Ok(mapper.Map<TicketDto>(ticketDomainModel));
        }

        // GET User
        // GET: /api/ticket

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ticketDomainModel = await ticketRepository.GetAllAsync();

            // Map Domain Model to DTO
            return Ok(mapper.Map<List<TicketDto>>(ticketDomainModel));
        }

        // Get User By Id
        // GET; /api/ticket/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ticketDomainModel = await ticketRepository.GetByIdAsync(id);

            if (ticketDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO
            return Ok(mapper.Map<TicketDto>(ticketDomainModel));
        }

        // Delete User By Id
        // DELETE: /api/users/{id}
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedTicketDomainModel = await ticketRepository.DeleteAsync(id);
            if (deletedTicketDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<TicketDto>(deletedTicketDomainModel));

            // Map Domain Model to DTO

        }
    }
}
