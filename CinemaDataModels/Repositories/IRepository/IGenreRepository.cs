using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.IRepository
{
    public interface IGenreRepository
    {
        Task<Genre> CreateAsync(Genre genre);
        Task<List<Genre>> GetAllAsync();
        Task<Genre?> GetByIdAsync(int id);
    }
}
