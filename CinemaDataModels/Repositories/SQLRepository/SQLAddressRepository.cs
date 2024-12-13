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
    public class SQLAddressRepository : IAddressRepository
    {
        private readonly CinemaContext dbContext;

        public SQLAddressRepository(CinemaContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Address> CreateAsync(Address address)
        {
            await dbContext.Addresses.AddAsync(address);
            await dbContext.SaveChangesAsync();
            return address;
        }

        public async Task<Address?> DeleteAsync(int id)
        {
            var existingAddress = await dbContext.Addresses.FirstOrDefaultAsync(x => x.AddressId == id);

            if (existingAddress == null)
            {
                return null;
            }

            dbContext.Addresses.Remove(existingAddress); // There is no Async remove in EF at this time.
            await dbContext.SaveChangesAsync();
            return existingAddress;
        }

        public async Task<List<Address>> GetAllAsync()
        {
            return await dbContext.Addresses.ToListAsync();
        }

        public async Task<Address?> GetByIdAsync(int id)
        {
            return await dbContext.Addresses
                         .FirstOrDefaultAsync(x => x.AddressId == id);


        }

        public async Task<Address?> UpdateAsync(int id, Address address)
        {
            var existingAddress = await dbContext.Addresses.FirstOrDefaultAsync(x => x.AddressId == id);
            if (existingAddress == null)
            {
                return null;
            }

            existingAddress.Street = address.Street;
            existingAddress.StreetNumber = address.StreetNumber;
            existingAddress.Building = address.Building;
            existingAddress.Floor = address.Floor;
            existingAddress.Direction = address.Direction;
            existingAddress.PostalCodeId = address.PostalCodeId;

            await dbContext.SaveChangesAsync();
            return existingAddress;
        }
    }
}
