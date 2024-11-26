using CinemaDataModels.Models.Entities;

namespace CinemaDataModels.Repositories
{
    public interface IPostalCodeRepository
    {
        Task<List<PostalCode>> GetAllAsync();
        Task<PostalCode?> GetByIdAsync(int id);
    }
}