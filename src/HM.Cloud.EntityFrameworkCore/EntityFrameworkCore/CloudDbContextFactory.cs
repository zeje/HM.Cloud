using HM.Cloud.Configuration;
using HM.Cloud.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HM.Cloud.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class CloudDbContextFactory : IDesignTimeDbContextFactory<CloudDbContext>
    {
        public CloudDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CloudDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(CloudConsts.ConnectionStringName)
            );

            return new CloudDbContext(builder.Options);
        }
    }
}