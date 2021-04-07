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
            modelBuilder.Entity<HP_CHECKUP>().Property(x => x.BODY_TEMPERATURE).HasPrecision(3, 2);
            modelBuilder.Entity<HP_CHECKUP>().Property(x => x.WEIGHT).HasPrecision(3, 2);
            modelBuilder.Entity<HP_CHECKUP>().Property(x => x.HEIGHT).HasPrecision(3, 2);

            modelBuilder.Entity<HS_ITEM>().Property(x => x.DP_RATE).HasPrecision(7, 2);
            modelBuilder.Entity<HS_ITEM>().Property(x => x.MRP_RATE).HasPrecision(7, 2);


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
        public DbSet<US_UNIT> US_UNIT { get; set; }


        public DbSet<HP_CHECKUP> HP_CHECKUP { get; set; }
        public DbSet<HP_DURATION> HP_DURATION { get; set; }
        public DbSet<HP_FREQUENCY> HP_FREQUENCY { get; set; }
        public DbSet<HP_INVESTIGATION> HP_INVESTIGATION { get; set; }
        public DbSet<HP_MEDICINE> HP_MEDICINE { get; set; }
        public DbSet<HP_PRESCRIPTION> HP_PRESCRIPTION { get; set; }
        public DbSet<HP_SHOW_TYPE> HP_SHOW_TYPE { get; set; }
        public DbSet<HP_SUGGESSION> HP_SUGGESSION { get; set; }
        public DbSet<HP_TOKEN> HP_TOKEN { get; set; }
        public DbSet<HS_DOCTOR> HS_DOCTOR { get; set; }
        public DbSet<HS_HOSPITAL> HS_HOSPITAL { get; set; }
        public DbSet<HS_ITEM> HS_ITEM { get; set; }
        public DbSet<HS_PATIENT> HS_PATIENT { get; set; }
        public DbSet<HS_TESTS> HS_TESTS { get; set; }

    }
}
