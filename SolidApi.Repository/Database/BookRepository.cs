using Microsoft.EntityFrameworkCore;
using SolidApi.Repository.Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{

    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext dbContext;
        public BookRepository(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Book> GetBookForNameAsync(string name)
        {
            return await dbContext.Books.Include(u => u.Company).AsNoTracking().FirstOrDefaultAsync(u => u.Tittle == name);
        }
    }
}
