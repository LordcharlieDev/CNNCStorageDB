using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Middle name")]
        public string MiddleName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }
        public int Salary { get; set; }
        public int Premium { get; set; }

        public Location Location { get; set; }
        public Position Position { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
