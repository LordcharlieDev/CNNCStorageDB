using CNNCStorageDB.Models;
using Microsoft.EntityFrameworkCore;

namespace CNNCStorageDB.Data
{
    public static class DatabaseSeedExtensions
    {
        public static void SeedDepartments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(new[]
            {
                new{Id = 1, Name = "Technical"},
                new{Id = 2, Name = "Human resource"},
                new{Id = 3, Name = "Sales"},
                new{Id = 4, Name = "Procurement"},
                new{Id = 5, Name = "Accounting"},
            });
        }
        public static void SeedPositions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(new[]
            {
                new{Id = 1, Name = "NodeJS Developer", DepartmentId = 1},
                new{Id = 2, Name = "React.JS Developer", DepartmentId = 1},
                new{Id = 3, Name = "Fulstack .NET Developer", DepartmentId = 1},
                new{Id = 4, Name = "Fulstack React.JS, Node.JS Developer", DepartmentId = 1},
                new{Id = 5, Name = "HR manager", DepartmentId = 3},
            });
        }
        public static void SeedWorkers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().HasData(new[]
            {
                new {Id = 1, FirstName = "Roman", MiddleName = "Tomecher", LastName = "Mukolaiovych", Email = "romantomechek@gmail.com", Phone = "+380678965789", PositionId = 3, Birthdate = DateTime.UtcNow, Salary = 3500m, Premium = 0m, LocationId = "1"},
                new {Id = 2, FirstName = "Oksana", MiddleName = "Stepanchuk", LastName = "Vadymivna", Email = "oksanastepanchuk@gmail.com", Phone = "+380938965789", PositionId = 5, Birthdate = DateTime.UtcNow, Salary = 1000m, Premium = 0m, LocationId = "1"}
            });
        }
        public static void SeedProjects(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(new[]
            {
                new{Id = 1, Name = "Phone caller for own workers", Budget = 100000m, StartTime = DateTime.UtcNow.AddMonths(-6), EndTime = DateTime.UtcNow, FinalPrice = 99880m},
            });
        }
        public static void SeedClients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new[]
{
                new {Id = 1, FullName = "US Commercial Freight - Rochester, NY Location", Address = " 333 Hollenbeck St, Rochester, NY 14621, US", Email = "uacommercialfreightrochester@gmail.com", Phone = "+15852661404" }
            });
        }
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new[]
{
                new { Id = 1, Login = "admin", Password = "admin" }
            });
        }
        public static void SeedLocations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(new[]
{
                new { Id = 1, Name = "Remote" },
                new { Id = 2, Name = "Rivne" },
                new { Id = 3, Name = "Lviv" }
            });
        }
    }
}
