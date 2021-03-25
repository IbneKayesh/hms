using hms.DataModel;
using Microsoft.EntityFrameworkCore;

namespace hms.DataAccess
{
    public class hmsDbContext : DbContext
    {
        public hmsDbContext(DbContextOptions<hmsDbContext> options) : base(options)
        {

        }
        public DbSet<US_USER> US_USER { get; set; }
    }
}
