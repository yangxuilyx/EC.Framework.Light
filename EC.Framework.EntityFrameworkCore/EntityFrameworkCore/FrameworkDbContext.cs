using EC.Framework.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace EC.Framework.EntityFrameworkCore.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class FrameworkDbContext : AbpDbContext<FrameworkDbContext>
    {
        public FrameworkDbContext(DbContextOptions<FrameworkDbContext> options) : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }
    }
}