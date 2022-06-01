using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNCStorageDB.Models
{
    public class Project
    {
        public Project()
        {
            Workers = new HashSet<Worker>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        [DisplayName("Start time")]
        public DateTime StartTime { get; set; }
        [DisplayName("End time")]
        public DateTime EndTime { get; set; }
        [DisplayName("Final price")]
        public int FinalPrice { get; set; }

        public Client Client { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
