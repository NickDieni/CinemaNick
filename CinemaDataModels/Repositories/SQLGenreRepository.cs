using CinemaDataModels.Data;
using CinemaDataModels.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories
{
    public class SQLGenreRepository : IGenreRepository
    {
        private readonly CinemaContext dbContext;

        public SQLGenreRepository(CinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Genre>> GetAllAsync()
        {
            return await dbContext.Genres.ToListAsync();
        }

        public async Task<Genre?> GetByIdAsync(int id)
        {
            return await dbContext.Genres
                         .FirstOrDefaultAsync(x => x.GenreId == id);


        }
    }
}
