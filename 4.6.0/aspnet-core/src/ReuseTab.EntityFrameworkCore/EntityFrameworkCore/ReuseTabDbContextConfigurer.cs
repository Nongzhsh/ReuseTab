using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ReuseTab.EntityFrameworkCore
{
    public static class ReuseTabDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReuseTabDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ReuseTabDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
