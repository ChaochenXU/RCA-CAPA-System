using Microsoft.EntityFrameworkCore;
using RCAONE.Models;

namespace RCAONE.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Containment> Containment { get; set; }
        public DbSet<Corrective> Corrective { get; set; }
        public DbSet<Fishbone> Fishbone { get; set; }
        public DbSet<Preventive> Preventive { get; set; }
        public DbSet<Problem> Problem { get; set; }
        public DbSet<Verification> Verification { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Whys> Whys { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<Analysiss> Analysiss { get; set; }
        public DbSet<AppFile> AppFile { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Containment>().ToTable("Containment");
            modelBuilder.Entity<Corrective>().ToTable("Corrective");
            modelBuilder.Entity<Fishbone>().ToTable("Fishbone");
            modelBuilder.Entity<Preventive>().ToTable("Preventive");
            modelBuilder.Entity<Problem>().ToTable("Problem");
            modelBuilder.Entity<Verification>().ToTable("Verification");
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<Whys>().ToTable("Whys");
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Score>().ToTable("Score");
            modelBuilder.Entity<Analysiss>().ToTable("Analysiss");
            modelBuilder.Entity<AppFile>().ToTable("AppFile");
        }
    }
}
