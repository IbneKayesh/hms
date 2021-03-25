using DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class hmsDbContext : DbContext
    {

        public DbSet<US_USER> US_USER { get; set; }
    }
    
}
