using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLSeatRepository : ISeatRepository
    {
        public Task<Seat> AddAsync(Seat seat)
        {
            throw new NotImplementedException();
        }

        public Task<Seat> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Seat>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Seat?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
