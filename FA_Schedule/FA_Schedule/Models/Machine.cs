using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_Schedule.Models
{
    public partial class Machine
    {
        public Machine()
        {
            SupportTicket = new HashSet<SupportTicket>();
        }
        public int MachineID { get; set; }
        public string Name { get; set; }
        public string GeneralRole { get; set; }
        public string InstalledRoles { get; set; }
        public int OperatingSysID { get; set; }
        public int MachineTypeID { get; set; }
        public MachineType MachineType { get; set; }
        public OperatingSys OperatingSys { get; set; }
        public ICollection<SupportTicket> SupportTicket { get; set; }
    }
}
