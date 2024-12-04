using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Repositories.SQLRepository
{
    public class SQLAddressRepository : IAddressRepository
    {
        public Task<Address> CreateAsync(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<Address?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Address>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Address?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Address?> UpdateAsync(int id, Address address)
        {
            throw new NotImplementedException();
        }
    }
}
