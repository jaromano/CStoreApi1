using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CStoreApi.EntityFrameworkCore
{
    public static class CStoreApiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CStoreApiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CStoreApiDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
