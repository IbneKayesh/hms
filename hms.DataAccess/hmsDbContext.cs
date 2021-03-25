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
        public DbSet<US_CHILD_MENU> US_CHILD_MENU { get; set; }
        public DbSet<US_GENDER> US_GENDER { get; set; }
        public DbSet<US_MARITAIL_STATUS> US_MARITAIL_STATUS { get; set; }
        public DbSet<US_MODULE> US_MODULE { get; set; }
        public DbSet<US_RELIGION> US_RELIGION { get; set; }
    }
}
