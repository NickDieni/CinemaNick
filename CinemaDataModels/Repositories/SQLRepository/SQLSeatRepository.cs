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
        public async Task<Seat?> DeleteAsync(int id)
        {
            var existingSeat = await dbContext.Seats.FirstOrDefaultAsync(x => x.SeatId == id);

            if (existingSeat == null)
            {
                return null;
            }

            dbContext.Seats.Remove(existingSeat); // There is no Async remove in EF at this time.
            await dbContext.SaveChangesAsync();
            return existingSeat;
        }

        public async Task<List<Seat>> GetAllAsync()
        {
            return await dbContext.Seats.ToListAsync();
        }

        public async Task<Seat?> GetByIdAsync(int id)
        {
            return await dbContext.Seats.FirstOrDefaultAsync(x => x.SeatId == id);
        }
    }
}
