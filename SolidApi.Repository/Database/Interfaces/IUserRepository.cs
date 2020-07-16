using SolidApi.Repository.Database.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{
    public interface IUserRepository
    {
        Task<User> GetUserForNameAsync(string name);
        Task<Movie> GetMovieForNameAsync(string name);
        Task<IEnumerable<Company>> GetUserCompaniesAsync(int userId);
    }
}