using CNNCStorageDB.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CNNCStorageDB.Data
{
    public class CNNCDbContext : DbContext
    {
        public CNNCDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SEGB2UP;Initial catalog = CNNCStorage;Integrated Security=True;Connect Timeout=5;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seeds
            modelBuilder.SeedDepartments();
            modelBuilder.SeedPositions();
            modelBuilder.SeedWorkers();
            modelBuilder.SeedProjects();
            modelBuilder.SeedClients();
            modelBuilder.SeedUsers();
            modelBuilder.SeedLocations();

            //Configuration
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new PositionConfig());
            modelBuilder.ApplyConfiguration(new WorkerConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new ClientConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new LocationConfig());
        }
    }
}
