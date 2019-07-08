using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ReuseTab.Configuration;
using ReuseTab.Web;

namespace ReuseTab.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ReuseTabDbContextFactory : IDesignTimeDbContextFactory<ReuseTabDbContext>
    {
        public ReuseTabDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReuseTabDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ReuseTabDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ReuseTabConsts.ConnectionStringName));

            return new ReuseTabDbContext(builder.Options);
        }
    }
}
