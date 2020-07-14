using Microsoft.EntityFrameworkCore;
using SolidApi.Repository.Database.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
            if (dbContext.Series.Count() == 0)
            {
                //IList<Series> seriesList = new List<Series>();

                Company companyitem = new Company();
                companyitem.Name = "Fitness";
                companyitem.Id = 2;

                Series item = new Series
                {
                    Id = 1,
                    Tittle = "Pan Wołodyjowski",
                    Company = companyitem
                };

                Company companyitem2 = new Company();
                companyitem2.Name = "PomiarMet";
                companyitem2.Id = 1;

                Series item2 = new Series
                {
                    Id = 2,
                    Tittle = "Botoks",
                    Company = companyitem2
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
