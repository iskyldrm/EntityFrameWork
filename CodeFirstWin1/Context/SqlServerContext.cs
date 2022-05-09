using CodeFirstWin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWin1.Context
{
    public class SqlServerContext:DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Stok> Stoklar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb; database=Market; Trusted_Connection = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stok>()
                .Property(p => p.StokAdi)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("Stok Adi");
            modelBuilder.Entity<Stok>()
                .Property(p => p.StokAciklama)
                .HasMaxLength(100);

        }
    }
}
