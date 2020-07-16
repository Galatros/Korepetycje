using Microsoft.EntityFrameworkCore;
using SolidApi.Repository.Database.Entities;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<Company>> GetUserCompaniesAsync(int userId)
        {
            var result = await dbContext.Users //wybieramy uzytkownikow select * from Users u
                .Include(u => u.UserToCompanies) // dodajemy tabele polaczen join UserToCompanies utc on u.id = utc.id
                .Where(u => u.Id == userId) // szukamy naszego uzytkownika where u.id = @userId (parametry!)
                .SelectMany(u => u.UserToCompanies) // wybieramy nasza druga tabele polaczen
                .Select(utc => utc.Company)
                .ToListAsync().ConfigureAwait(false); //wybieramy firmy na ktora wskazuje

            return result;
        }
    }
}
