using Microsoft.EntityFrameworkCore;
using SolidApi.Repository.Database.Entities;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{
    public class MovieRepository : IMovieRepository
    {
        private readonly LibraryDbContext dbContext;

        public MovieRepository(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Movie> GetMovieForNameAsync(string name)
        {
            return await dbContext.Movies.Include(u => u.Company).AsNoTracking().FirstOrDefaultAsync(u => u.Tittle == name);
        }
    }
}
