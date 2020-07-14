using SolidApi.Repository.Database.Entities;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{
    public interface IBookRepository
    {
        Task<Book> GetBookForNameAsync(string name);
    }
}