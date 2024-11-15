using DemoCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models
{
    // Databank
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=(localdb)\MSSQLLocalDB;initial catalog=DemoEF123");
        }

        // Tabellen
        public DbSet<Persoon> Personen { get; set; }
        public DbSet<WoonPlaats> WoonPlaatsen { get; set; }

        public DbSet<Docent> Docenten { get; set; }
        public DbSet<Student> Studenten { get; set; }
    }
}
