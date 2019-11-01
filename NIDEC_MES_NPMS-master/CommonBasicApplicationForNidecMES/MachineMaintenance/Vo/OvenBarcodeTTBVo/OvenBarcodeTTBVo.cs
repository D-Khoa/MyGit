using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.OvenBarcodeTTBVo
{
    class OvenBarcodeTTBVo : ValueObject
    {
        public string OvenModel { get; set; }
        public string OvenLine { get; set; }
        public string OvenProcess { get; set; }
        public string Barcode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string OvenMinTemp { get; set; }
        public string OvenMaxTemp { get; set; }
        public string OvenCurrTemp { get; set; }
        public string TimeSet { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
    }
}
