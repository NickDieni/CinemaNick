using CinemaDataModels.Models.Entities;
using CinemaDataModels.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaDataModels.Repositories.IRepository;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLPostalCodeRepository : IPostalCodeRepository
    {
        private readonly CinemaContext dbContext;

        public SQLPostalCodeRepository(CinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<PostalCode>> GetAllAsync()
        {
            return await dbContext.PostalCodes.ToListAsync();
        }

        public async Task<PostalCode?> GetByIdAsync(int id)
        {
            return await dbContext.PostalCodes
                         .FirstOrDefaultAsync(x => x.PostalCodeId == id);
        }
        public async Task<PostalCode> CreateAsync(PostalCode postalCode)
        {
            await dbContext.PostalCodes.AddAsync(postalCode);
            await dbContext.SaveChangesAsync();
            return postalCode;
        }
    }
}
