using CinemaDataModels.Data;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLSeatRepository : ISeatRepository
    {
        private readonly CinemaContext dbContext;

        public SQLSeatRepository(CinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Seat> CreateAsync(Seat seat)
        {
            await dbContext.Seats.AddAsync(seat);
            await dbContext.SaveChangesAsync();
            return seat;
        }
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
