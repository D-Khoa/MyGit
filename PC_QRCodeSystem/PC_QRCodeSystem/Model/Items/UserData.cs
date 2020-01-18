using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_QRCodeSystem.Model
{
    public static class UserData
    {
        public static string dept { get; set; }
        public static string usercode { get; set; }
        public static string username { get; set; }
        public static DateTime logintime { get; set; }
        public static List<string> role_permision { get; set; }
    }
}
