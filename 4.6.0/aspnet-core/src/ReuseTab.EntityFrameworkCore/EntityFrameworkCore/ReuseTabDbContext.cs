using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ReuseTab.Authorization.Roles;
using ReuseTab.Authorization.Users;
using ReuseTab.MultiTenancy;

namespace ReuseTab.EntityFrameworkCore
{
    public class ReuseTabDbContext : AbpZeroDbContext<Tenant, Role, User, ReuseTabDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ReuseTabDbContext(DbContextOptions<ReuseTabDbContext> options)
            : base(options)
        {
        }
    }
}
