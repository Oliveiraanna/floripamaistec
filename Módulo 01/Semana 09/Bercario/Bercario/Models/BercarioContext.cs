using Bercario.Models.Configurations;
using Bercario.Models;
using System.IO;
using Microsoft.EntityFrameworkCore;


namespace Bercario.Models
{
    public class BercarioContext : DbContext
    {
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-88F224O\\SQLEXPRESS01;Database=bercario;User ID=sa;Password=2909;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BebeConfiguration());
            modelBuilder.ApplyConfiguration(new MaeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration(new PartoConfiguration());
        }
    }

}