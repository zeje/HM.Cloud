using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HM.Cloud.EntityFrameworkCore
{
    public class CloudDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public CloudDbContext(DbContextOptions<CloudDbContext> options)
            : base(options)
        {
        }
        public DbSet<SoftVersion> SoftVersions { get; set; }
    }
}
