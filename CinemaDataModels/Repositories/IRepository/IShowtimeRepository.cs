using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.IRepository
{
    public interface IShowtimeRepository
    {
        Task<List<Showtime>> GetAllAsync();
        Task<Showtime?> GetByIdAsync(int id);
        Task<Showtime> CreateAsync(Showtime showtime);
        Task<Showtime> DeleteAsync(int id);
    }
}
