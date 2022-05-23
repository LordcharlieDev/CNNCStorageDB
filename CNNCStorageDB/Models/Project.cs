using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNCStorageDB.Models
{
    public class Project
    {
        public Project()
        {
            Clients = new HashSet<Client>();
            Workers = new HashSet<Worker>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int FinalPrice { get; set; }

        public ICollection<Client> Clients { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
