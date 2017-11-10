using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class CatalogContextSeed
    {
        public static async Task SeedAsync(IApplicationBuilder applicationBuilder,
            MySchoolContext catalogContext,
            ILoggerFactory loggerFactory, int? retry = 0)
        {
            var retryForAvailability = retry;
            try
            {
                // TODO: Only run this if using a real database
                // context.Database.Migrate();


            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<CatalogContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(applicationBuilder, catalogContext, loggerFactory, retryForAvailability);
                }
            }
        }
    }
}
