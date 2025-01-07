using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDataModels.Models.Entities;

namespace CinemaDataModels.Repositories.IRepository
{
    public interface ITicketRepository
    {
        Task<List<Ticket>> GetAllAsync();
        Task<Ticket?> GetByIdAsync(int id);
        Task<Ticket> CreateAsync(Ticket ticket);
        Task<Ticket> DeleteAsync(int id);
    }
}
