using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DemoCore.Authorization.Roles;
using DemoCore.Authorization.Users;
using DemoCore.MultiTenancy;
using DemoCore.GoodsManager;

namespace DemoCore.EntityFrameworkCore
{
    public class DemoCoreDbContext : AbpZeroDbContext<Tenant, Role, User, DemoCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DbSet<Category> GoodsCategory { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DemoCoreDbContext(DbContextOptions<DemoCoreDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("T");            
            base.OnModelCreating(modelBuilder);
        }
    }
}
