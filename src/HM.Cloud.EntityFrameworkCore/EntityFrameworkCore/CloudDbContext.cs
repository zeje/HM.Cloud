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
                .HasValue<Permission>(PermissionType.Default)
                .HasValue<Page>(PermissionType.Page)
                .HasValue<Button>(PermissionType.Button)
                .HasValue<Grid>(PermissionType.Grid)
                .HasValue<GridField>(PermissionType.GridField);
        }

        #region 系统权限部分
        /// <summary>
        /// 按钮
        /// </summary>
        public DbSet<Button> Buttons { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public DbSet<Department> Departments { get; set; }
        /// <summary>
        /// 部门角色
        /// </summary>
        public DbSet<DepartmentRole> DepartmentRoles { get; set; }
        /// <summary>
        /// 表格
        /// </summary>
        public DbSet<Grid> Grids { get; set; }
        /// <summary>
        /// 表格字段
        /// </summary>
        public DbSet<GridField> GridFields { get; set; }
        /// <summary>
        /// 页面
        /// </summary>
        public DbSet<Page> Pages { get; set; }
        /// <summary>
        /// 权限
        /// </summary>
        public DbSet<Permission> Permissions { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public DbSet<Role> Roles { get; set; }
        /// <summary>
        /// 角色按钮
        /// </summary>
        public DbSet<RoleButton> RoleButtons { get; set; }
        /// <summary>
        /// 角色表格
        /// </summary>
        public DbSet<RoleGrid> RoleGrids { get; set; }
        /// <summary>
        /// 角色表格字段
        /// </summary>
        public DbSet<RoleGridField> RoleGridFields { get; set; }
        /// <summary>
        /// 角色页面
        /// </summary>
        public DbSet<RolePage> RolePages { get; set; }
        /// <summary>
        /// 角色权限
        /// </summary>
        public DbSet<RolePermission> RolePermissions { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        public DbSet<SoftVersion> SoftVersions { get; set; }
    }
}
