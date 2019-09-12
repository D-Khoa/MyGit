using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_Schedule.Models
{
    public partial class OperatingSys
    {
        public OperatingSys()
        {
            Machine = new HashSet<Machine>();
        }
        public int OperatingSysID { get; set; }
        public string Name { get; set; }
        public bool StillSupported { get; set; }
        public ICollection<Machine> Machine { get; set; }
    }
}
