using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CStoreApi.Configuration;
using CStoreApi.Web;

namespace CStoreApi.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CStoreApiDbContextFactory : IDesignTimeDbContextFactory<CStoreApiDbContext>
    {
        public CStoreApiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CStoreApiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CStoreApiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CStoreApiConsts.ConnectionStringName));

            return new CStoreApiDbContext(builder.Options);
        }
    }
}
