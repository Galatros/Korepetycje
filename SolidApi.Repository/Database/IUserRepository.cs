using SolidApi.Repository.Database.Entities;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{
    public interface IUserRepository
    {
        Task<User> GetUserForNameAsync(string name);
    }
}