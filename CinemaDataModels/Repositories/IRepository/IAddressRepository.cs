using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaDataModels.Repositories.IRepository
{
    //Interface is used for test and to make sure that whatever is in
    //SQLRepository matches with together, for example CreateAsync needs to be the same each place 
    public interface IAddressRepository 
    {
        Task<Address> CreateAsync(Address address);
        Task<List<Address>> GetAllAsync();
        Task<Address?> GetByIdAsync(int id);
        Task<Address?> UpdateAsync(int id, Address address);
        Task<Address?> DeleteAsync(int id);
    }
}
