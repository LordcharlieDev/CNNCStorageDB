using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNCStorageDB.Models
{
    public class Client
    {
        public Client()
        {
            Projects = new HashSet<Project>();
        }
        public int Id { get; set; }
        [DisplayName("Full name")]
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
