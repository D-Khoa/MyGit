using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.OvenBarcodeTTBDao;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.OvenBarcodeTTBCbm
{
    class GetBarcodeCbm:CbmController
    {
        private static readonly DataAccessObject getDao = new GetBarcodeDao();
        public ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            if (vo == null)
            {
                return null;
            }
            return getDao.Execute(trxContext, vo);
        }
    }
}
