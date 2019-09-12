using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_Schedule.Models
{
    public partial class MachineType
    {
        public MachineType()
        {
            Machine = new HashSet<Machine>();
        }
        public int MchineID { get; set; }
        public string Description { get; set; }
        public ICollection<Machine> Machine { get; set; }
    }
}
