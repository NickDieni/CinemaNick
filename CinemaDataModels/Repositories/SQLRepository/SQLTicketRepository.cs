
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLTicketRepository : ITicketRepository
    {
        public async Task<Ticket> AddAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public async Task<Ticket> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Ticket>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Ticket?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Ticket> UpdateAsync(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
