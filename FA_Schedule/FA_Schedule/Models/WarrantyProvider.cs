using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_Schedule.Models
{
    public partial class WarrantyProvider
    {
        public WarrantyProvider()
        {
            MachineWarranty = new HashSet<MachineWarranty>();
        }
        public int WarrantyProviderID { get; set; }
        public string ProviderName { get; set; }
        public int? SupportExtension { get; set; }
        public string SupportNumber { get; set; }
        ICollection<MachineWarranty> MachineWarranty { get; set; }
    }
}
