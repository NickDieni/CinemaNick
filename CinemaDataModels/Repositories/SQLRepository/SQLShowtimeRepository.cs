using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLShowtimeRepository : IShowtimeRepository
    {
        public Task<Showtime> AddAsync(Showtime showtime)
        {
            throw new NotImplementedException();
        }

        public Task<Showtime> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Showtime>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Showtime?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Showtime> UpdateAsync(Showtime showtime)
        {
            throw new NotImplementedException();
        }
    }
}
