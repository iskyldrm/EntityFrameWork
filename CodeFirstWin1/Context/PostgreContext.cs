using CodeFirstWin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWin1.Context
{
    public class PostgreContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Stok> Stoklar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"server=127.0.0.1; database=Market; userid=postgres; password=isakisak1234");
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
