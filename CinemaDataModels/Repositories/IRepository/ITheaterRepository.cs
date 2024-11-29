using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.IRepository
{
    public interface ITheaterRepository
    {
        Task<List<Theater>> GetAllAsync();
        Task<Theater?> GetByIdAsync(int id);
        Task<Theater> AddAsync(Theater theater);
        Task<Theater> UpdateAsync(Theater theater);
        Task<Theater> DeleteAsync(int id);
    }
}
