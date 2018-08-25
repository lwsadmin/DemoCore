using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DemoCore.EntityFrameworkCore
{
    public static class DemoCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DemoCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DemoCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
