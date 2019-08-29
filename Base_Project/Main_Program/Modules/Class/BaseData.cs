using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class BaseData
    {
        private static readonly BaseData data = new BaseData();
        public static BaseData GetData()
        {
            return data;
        }
        public bool duplicate { get; set; }
        public int sum_dice { get; set; }
    }
}
