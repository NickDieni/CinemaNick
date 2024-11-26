using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories
{
    public class SQLPostalCodeRepository : IPostalCodeRepository
    {
        private readonly MyDbContext dbContext;
    }
}
