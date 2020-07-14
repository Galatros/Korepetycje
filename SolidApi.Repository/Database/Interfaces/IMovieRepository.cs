using SolidApi.Repository.Database.Entities;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{
    public interface IMovieRepository
    {
        Task<Movie> GetMovieForNameAsync(string name);
    }
}