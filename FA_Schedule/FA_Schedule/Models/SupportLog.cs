using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA_Schedule.Models
{
    public partial class SupportLog
    {
        public int SupportLogID { get; set; }
        public DateTime SupportLogEntryDate { get; set; }
        public string SupportLogEntry { get; set; }
        public string SupportLogUpdatedBy { get; set; }
        public int SupportTicketID { get; set; }
        public SupportTicket SupportTicket { get; set; }
    }
}
