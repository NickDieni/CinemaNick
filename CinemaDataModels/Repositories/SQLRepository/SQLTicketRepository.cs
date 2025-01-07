
using CinemaDataModels.Data;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using System.Data.Entity;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLTicketRepository : ITicketRepository
    {
        private readonly CinemaContext dbContext;

        public SQLTicketRepository(CinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Ticket> CreateAsync(Ticket ticket)
        {
            await dbContext.Tickets.AddAsync(ticket);
            await dbContext.SaveChangesAsync();
            return ticket;
        }
        public async Task<Ticket?> DeleteAsync(int id)
        {
            var existingTicket = await dbContext.Tickets.FirstOrDefaultAsync(x => x.TicketId == id);

            if (existingTicket == null)
            {
                return null;
            }

            dbContext.Tickets.Remove(existingTicket); // There is no Async remove in EF at this time.
            await dbContext.SaveChangesAsync();
            return existingTicket;
        }

        public async Task<List<Ticket>> GetAllAsync()
        {
            return await dbContext.Tickets.ToListAsync();
        }

        public async Task<Ticket?> GetByIdAsync(int id)
        {
            return await dbContext.Tickets.FirstOrDefaultAsync(x => x.TicketId == id);
        }
    }
}
