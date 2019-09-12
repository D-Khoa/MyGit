using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_Schedule.Models
{
    public partial class MachineWarranty
    {
        public int MachineWarrantyID { get; set; }
        public string ServiceTag { get; set; }
        public DateTime WarrantyExpiration { get; set; }
        public int MachineID { get; set; }
        public int WarrantyProviderID { get; set; }
        public WarrantyProvider WarrantyProvider { get; set; }
    }
}
