using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.Nidec2019Cbm
{
    public class AssetMaster2019Cbm : CbmController
    {
        private static readonly DataAccessObject getDao = new AssetMaster2019Dao();
        public ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            if (vo == null)
                return null;
            return getDao.Execute(trxContext, vo);
        }
    }
}
