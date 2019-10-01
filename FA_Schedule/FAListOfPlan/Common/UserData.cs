using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAListOfPlan.Common
{
    public class Userdata
    {
        private static readonly Userdata usr = new Userdata();
        public static Userdata getUser()
        {
            return usr;
        }
        public string Username { get; set; }
        public string UserID { get; set; }
        public string Location { get; set; }
    }
}
