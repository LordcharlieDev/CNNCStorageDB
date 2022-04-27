using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNCStorageDB.Models
{
    public class Worker
    {
        public Worker()
        {
            Projects = new HashSet<Project>();
        }
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }
        public decimal Salary { get; set; }
        public decimal Premium { get; set; }

        public Position Position { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
