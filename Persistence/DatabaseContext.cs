using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabaseContext() : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<Domain.Category> Categories { get; set; }

        public DbSet<Domain.Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=Database\\MySQLite.db";

            optionsBuilder.UseSqlite(connectionString: connectionString);
        }
    }
}
