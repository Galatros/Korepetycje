using Microsoft.EntityFrameworkCore;
using SolidApi.Repository.Database.Entities;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryDbContext dbContext;

        public UserRepository(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //CRUD Create Read Update Delete
        public async Task<User> GetUserForNameAsync(string name)
        {
            //select Users.Name, Companies.Name from Users
            // join Companies on Companies.Id == Users.CompanyId
            // where Users.Name == 'name'

            return await dbContext.Users.Include(u => u.Company).AsNoTracking().FirstOrDefaultAsync(u => u.Name == name);

            // AsNoTracking
            // dbContext.SaveChangesAsync();
        }

        public async Task Add(User user)
        {
            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Movie> GetMovieForNameAsync(string name)
        {
            return await dbContext.Movies.Include(u => u.Company).AsNoTracking().FirstOrDefaultAsync(u => u.Tittle == name);
        }
    }
}
