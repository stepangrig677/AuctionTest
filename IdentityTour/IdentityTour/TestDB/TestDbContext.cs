using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IdentityTour.TestDB
{
    public class TestDbContext : DbContext
    {
        public TestDbContext() : base("Identity")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Betting> Bettings { get; set; }
    }
    
}