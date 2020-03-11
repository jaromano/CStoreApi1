using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CStoreApi.Authorization.Roles;
using CStoreApi.Authorization.Users;
using CStoreApi.MultiTenancy;

namespace CStoreApi.EntityFrameworkCore
{
    public class CStoreApiDbContext : AbpZeroDbContext<Tenant, Role, User, CStoreApiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CStoreApiDbContext(DbContextOptions<CStoreApiDbContext> options)
            : base(options)
        {
        }
    }
}
