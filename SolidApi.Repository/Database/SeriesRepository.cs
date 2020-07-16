using Microsoft.EntityFrameworkCore;
using SolidApi.Repository.Database.Entities;
using System.Threading.Tasks;

namespace SolidApi.Repository.Database
{
    public class SeriesRepository : ISeriesRepository
    {
        private readonly LibraryDbContext dbContext;

        public SeriesRepository(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Series> GetSeriesForNameAsync(string name)
        {
            await LoadInitalizationData();
            return await dbContext.Series.Include(u => u.Company).AsNoTracking().FirstOrDefaultAsync(u => u.Tittle == name);
        }
        public async Task Add(Series series)
        {
            dbContext.Series.Add(series);
            await dbContext.SaveChangesAsync();
        }

        private async Task LoadInitalizationData()
        {
            if (!await dbContext.Series.AnyAsync().ConfigureAwait(false))
            {
                //IList<Series> seriesList = new List<Series>();

                Company fitnes = await dbContext.Companies.FirstOrDefaultAsync(c => c.Id == 2).ConfigureAwait(false);
                Company pomiarMet = await dbContext.Companies.FirstOrDefaultAsync(c => c.Id == 1).ConfigureAwait(false);

                Series item = new Series
                {
                    Tittle = "Pan Wołodyjowski",
                    Company = fitnes
                };

                Series item2 = new Series
                {
                    Tittle = "Botoks",
                    Company = pomiarMet
                };


                //TODO To dobry pomysł??
                //seriesList.Add(item);
                //seriesList.Add(item2);
                //dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Comapnies] ON");
                //await dbContext.AddRangeAsync(seriesList);

                //await dbContext.SaveChangesAsync();

                //dbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Comapnies] OFF");

                await Add(item);
                await Add(item2);
            }
        }
    }
}
