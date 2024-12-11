using CinemaDataModels.Data;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLTheaterRepository : ITheaterRepository
    {
        private readonly CinemaContext dbContext;

        public SQLTheaterRepository(CinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Theater> CreateAsync(Theater theater)
        {
            await dbContext.Theaters.AddAsync(theater);
            await dbContext.SaveChangesAsync();
            return theater;
        }

        public async Task<Theater?> DeleteAsync(int id)
        {
            var existingTheater = await dbContext.Theaters.FirstOrDefaultAsync(x => x.TheaterId == id);

            if (existingTheater == null)
            {
                return null;
            }

            dbContext.Theaters.Remove(existingTheater); // There is no Async remove in EF at this time.
            await dbContext.SaveChangesAsync();
            return existingTheater;
        }

        public async Task<List<Theater>> GetAllAsync()
        {
            return await dbContext.Theaters.ToListAsync();
        }

        public async Task<Theater?> GetByIdAsync(int id)
        {
            return await dbContext.Theaters
                         .FirstOrDefaultAsync(x => x.TheaterId == id);


        }

        public async Task<Theater?> UpdateAsync(int id, Theater theater)
        {
            var existingTheater = await dbContext.Theaters.FirstOrDefaultAsync(x => x.TheaterId == id);
            if (existingTheater == null)
            {
                return null;
            }

            existingTheater.TheaterName = theater.TheaterName;
            existingTheater.Capacity = theater.Capacity;
            existingTheater.AddressId = theater.AddressId;

            await dbContext.SaveChangesAsync();
            return existingTheater;
        }
    }
}
