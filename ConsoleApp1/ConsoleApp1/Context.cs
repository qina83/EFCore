using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class EFContext : DbContext
    {

        public EFContext(DbContextOptions<EFContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Model>().Property(t => t.State).HasConversion<int>();
        }

        public DbSet<Model> Models { get; set; }
    }
}
