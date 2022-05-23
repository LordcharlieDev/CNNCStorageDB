using CNNCStorageDB.Data;
using CNNCStorageDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNCStorageDB
{
    public class CNNCDbQueries
    {
        private readonly CNNCDbContext db;

        public CNNCDbQueries(CNNCDbContext context)
        {
            db = context;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return db.Departments.ToList();
        }
        public IEnumerable<Position> GetAllPositions()
        {
            return db.Positions.Include(p => p.Department).ToList();
        }
        public IEnumerable<Worker> GetAllWorkers()
        {
            return db.Workers.Include(w => w.Position)
                             .Include(w => w.Location)
                             .ToList();
        }
        public IEnumerable<Project> GetAllProjects()
        {
            return db.Projects.ToList();
        }
        public IEnumerable<Client> GetAllClients()
        {
            return db.Clients.ToList();
        }
        public IEnumerable<Location> GetAllLocations()
        {
            return db.Locations.ToList();
        }

        public bool CheckUser(string login, string password)
        {
            var result = db.Users.Where(u => u.Login == login && u.Password == password).ToList().Count;
            if (result == 1)
            {
                return true;
            }
            return false;
        }
    }
}
