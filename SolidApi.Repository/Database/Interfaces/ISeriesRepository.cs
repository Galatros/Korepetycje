using SolidApi.Repository.Database.Entities;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{
    public interface ISeriesRepository
    {
        Task<Series> GetSeriesForNameAsync(string name);
    }
}