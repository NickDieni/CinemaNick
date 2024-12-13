using CinemaDataModels.Models.Entities;

namespace CinemaDataModels.Repositories.IRepository
{
    public interface IPostalCodeRepository
    {
        Task<List<PostalCode>> GetAllAsync();
        Task<PostalCode?> GetByIdAsync(int id);
        Task<PostalCode> CreateAsync(PostalCode postalCode);

    }
}