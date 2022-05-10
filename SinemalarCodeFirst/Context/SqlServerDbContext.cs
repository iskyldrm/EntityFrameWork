using Microsoft.EntityFrameworkCore;
using SinemalarCodeFirst.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemalarCodeFirst.Context
{
    class SqlServerDbContext:DbContext
    {
        public DbSet<Gosterim> Gosterim { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=SinemalarCodeFirst;trusted_Connection=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gosterim>().HasKey(x => new { x.SalonId, x.HaftaId, x.SeansId });
        }

        
    }
}
