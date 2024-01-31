using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;

namespace Solid.Core
{
    public class DataContext: DbContext
    {
        public DbSet<Patient> patients { get; set; }
        public DbSet<Medicine> medicines { get; set; }
        public DbSet<Chemist> chemists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=pharm_db");
        }



    }
}
