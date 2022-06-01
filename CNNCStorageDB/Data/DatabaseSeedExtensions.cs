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
                new{Id = 3, Name = "Fullstack .NET Developer", DepartmentId = 1},
                new{Id = 4, Name = "Fullstack React.JS, Node.JS Developer", DepartmentId = 1},
                new{Id = 5, Name = "HR manager", DepartmentId = 2},
                new{Id = 6, Name = "Team Lead", DepartmentId = 1},
                new{Id = 7, Name = "Product Manager", DepartmentId = 1},
                new{Id = 8, Name = "Project Manager", DepartmentId = 1},
                new{Id = 9, Name = "Marketer", DepartmentId = 3},
                new{Id = 10, Name = "PR manager", DepartmentId = 3},
                new{Id = 11, Name = "Warehouse manager", DepartmentId = 4},
                new{Id = 12, Name = "Bookkeeper", DepartmentId = 5},
            });
        }
        public static void SeedWorkers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().HasData(new[]
            {
                new {Id = 1, FirstName = "Roman",  MiddleName = "Tomecher",   LastName = "Mukolaiovych", Email = "romantomechek@gmail.com",    Phone = "+380678965789", PositionId = 1, Birthdate = Convert.ToDateTime("12/05/2000"), Salary = 3500, Premium = 0, LocationId = 1},
                new {Id = 2, FirstName = "Oksana", MiddleName = "Stepanchuk", LastName = "Vadymivna",    Email = "oksanastepanchuk@gmail.com", Phone = "+380938965789", PositionId = 2, Birthdate = Convert.ToDateTime("12/10/1995"), Salary = 1000, Premium = 0, LocationId = 1},
                new {Id = 3, FirstName = "Inna",   MiddleName = "Koltaniuk",  LastName = "Mykolaivna",   Email = "innakoltaniuk@gmail.com",    Phone = "+380938467895", PositionId = 2, Birthdate = Convert.ToDateTime("06/06/1993"), Salary = 1000, Premium = 0, LocationId = 2},
                new {Id = 4, FirstName = "Katia",  MiddleName = "Tomecher",   LastName = "Oleksiivna",   Email = "katiatomecher@gmail.com",    Phone = "+380684579512", PositionId = 2, Birthdate = Convert.ToDateTime("07/24/1997"), Salary = 1000, Premium = 0, LocationId = 2},
                new {Id = 5, FirstName = "Sasha",  MiddleName = "Melnik",     LastName = "Artemivna",    Email = "sashamelnik@gmail.com",      Phone = "+380995467845", PositionId = 2, Birthdate = Convert.ToDateTime("08/30/1999"), Salary = 1000, Premium = 0, LocationId = 3},
            });
        }
        public static void SeedProjects(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(new[]
            {
                new{Id = 1, Name = "Phone caller for own workers", Budget = 100000, StartTime = DateTime.Now.AddMonths(-6), EndTime = DateTime.Now, FinalPrice = 99880, ClientId = 1},
            });
        }
        public static void SeedClients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new[]
{
                new {Id = 1, FullName = "US Commercial Freight - Rochester, NY Location", Address = " 333 Hollenbeck St, Rochester, NY 14621, US", Email = "uacommercialfreightrochester@gmail.com", Phone = "+158526625744" }
            });
        }
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new[]
{
                new { Id = 1, Login = "administrator",     Password = "F@1ders1",  IsAdmin = true },
                new { Id = 2, Login = "Oksana.Stepanchuk", Password = "Oksana123", IsAdmin = false },
                new { Id = 3, Login = "Inna.Koltaniuk",    Password = "Inna1234",  IsAdmin = false },
                new { Id = 4, Login = "Katia.Tomecher",    Password = "Katia123",  IsAdmin = false },
                new { Id = 5, Login = "Sasha.Melnik",      Password = "Sasha123",  IsAdmin = false },
            }); ;
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
