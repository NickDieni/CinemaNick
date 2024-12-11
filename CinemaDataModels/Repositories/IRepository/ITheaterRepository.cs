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
        Task<Theater> CreateAsync(Theater theater);
        Task<List<Theater>> GetAllAsync();
        Task<Theater?> GetByIdAsync(int id);
        Task<Theater?> UpdateAsync(int id, Theater user);
        Task<Theater?> DeleteAsync(int id);
    }
}
