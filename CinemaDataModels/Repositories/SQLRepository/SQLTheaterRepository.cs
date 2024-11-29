using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLTheaterRepository : ITheaterRepository
    {
        public Task<Theater> AddAsync(Theater theater)
        {
            throw new NotImplementedException();
        }

        public Task<Theater> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Theater>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Theater?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Theater> UpdateAsync(Theater theater)
        {
            throw new NotImplementedException();
        }
    }
}
