using CinemaDataModels.Data;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLShowtimeRepository : IShowtimeRepository
    {
        private readonly CinemaContext dbContext;

        public SQLShowtimeRepository(CinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Showtime> CreateAsync(Showtime showtime)
        {
            await dbContext.Showtimes.AddAsync(showtime);
            await dbContext.SaveChangesAsync();
            return showtime;
        }
        public async Task<Showtime?> DeleteAsync(int id)
        {
            var existingShowtime = await dbContext.Showtimes.FirstOrDefaultAsync(x => x.ShowtimeId == id);

            if (existingShowtime == null)
            {
                return null;
            }

            dbContext.Showtimes.Remove(existingShowtime); // There is no Async remove in EF at this time.
            await dbContext.SaveChangesAsync();
            return existingShowtime;
        }

        public async Task<List<Showtime>> GetAllAsync()
        {
            return await dbContext.Showtimes.ToListAsync();
        }

        public async Task<Showtime?> GetByIdAsync(int id)
        {
            return await dbContext.Showtimes.FirstOrDefaultAsync(x => x.ShowtimeId == id);
        }
    }
}
