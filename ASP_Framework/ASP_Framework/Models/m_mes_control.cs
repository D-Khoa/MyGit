using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Framework.Models
{
    public class m_mes_control
    {
        public int control_id { get; set; }
        public string control_cd { get; set; }
        public string control_name { get; set; }
        public string control_parent { get; set; }
        public string reg_user { get; set; }
        public DateTime reg_date { get; set; }
    }
}