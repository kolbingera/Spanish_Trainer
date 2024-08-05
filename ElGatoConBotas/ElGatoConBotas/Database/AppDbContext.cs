using ElGatoConBotas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGatoConBotas.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Vocabulary> Vocabularies { get; set; }

        // Constructor accepting DbContextOptions
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}