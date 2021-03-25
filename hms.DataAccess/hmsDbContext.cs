using hms.DataModel;
using Microsoft.EntityFrameworkCore;

namespace hms.DataAccess
{
    public class hmsDbContext : DbContext
    {
        public hmsDbContext(DbContextOptions<hmsDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<US_USER_ROLE>()
                .HasKey(c => new { c.US_USER_ID, c.US_ROLE_ID })
                .HasName("PK_US_USER_ROLE_ID");


            modelBuilder.Entity<US_ROLE_MENU>()
                .HasKey(c => new { c.US_ROLE_ID, c.US_CHILD_MENU_ID })
                .HasName("PK_US_ROLE_MENU_ID");
        }
        public DbSet<US_BLOOD_GROUP> US_BLOOD_GROUP { get; set; }
        public DbSet<US_CHILD_MENU> US_CHILD_MENU { get; set; }
        public DbSet<US_GENDER> US_GENDER { get; set; }        
        public DbSet<US_MARITAIL_STATUS> US_MARITAIL_STATUS { get; set; }
        public DbSet<US_MODULE> US_MODULE { get; set; }
        public DbSet<US_PARENT_MENU> US_PARENT_MENU { get; set; }
        public DbSet<US_RELIGION> US_RELIGION { get; set; }        
        public DbSet<US_ROLE> US_ROLE { get; set; }
        public DbSet<US_ROLE_MENU> US_ROLE_MENU { get; set; }
        public DbSet<US_TYPE> US_TYPE { get; set; }
        public DbSet<US_USER> US_USER { get; set; }
        public DbSet<US_USER_ROLE> US_USER_ROLE { get; set; }
    }
}
