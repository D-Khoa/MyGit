using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.OvenBarcodeTTBVo;
using Com.Nidec.Mes.Framework;


namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.OvenBarcodeTTBDao
{
    public class SearchDataDao:AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            OvenBarcodeTTBVo inVo = (OvenBarcodeTTBVo)vo;
            StringBuilder sql = new StringBuilder();

        }
    }
}
