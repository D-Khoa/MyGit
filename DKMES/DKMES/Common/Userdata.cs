using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKMES.Common
{
    public class Userdata
    {
        public static readonly Userdata user = new Userdata();
        public static Userdata GetData()
        {
            return user;
        }
        public string userId { get; set; }
        public string userName { get; set; }
        public string factory { get; set; }
        public string reg_user { get; set; }
    }
}
