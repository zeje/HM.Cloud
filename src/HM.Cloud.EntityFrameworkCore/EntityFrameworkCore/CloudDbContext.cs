using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace HM.Cloud
{
    public class CloudDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public CloudDbContext(DbContextOptions<CloudDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Permission>()
                .HasDiscriminator<PermissionType>("PermissionType")
                .HasValue<Page>(PermissionType.Page)
                .HasValue<Button>(PermissionType.Button)
                .HasValue<GridField>(PermissionType.GridField);
        }

        public DbSet<SoftVersion> SoftVersions { get; set; }
    }
}
