using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DemoCore.Configuration;
using DemoCore.Web;

namespace DemoCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DemoCoreDbContextFactory : IDesignTimeDbContextFactory<DemoCoreDbContext>
    {
        public DemoCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DemoCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DemoCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DemoCoreConsts.ConnectionStringName));

            return new DemoCoreDbContext(builder.Options);
        }
    }
}
