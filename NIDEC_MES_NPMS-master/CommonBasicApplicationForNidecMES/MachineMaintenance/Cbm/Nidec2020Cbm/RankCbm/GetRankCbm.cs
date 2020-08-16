﻿using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm.Nidec2020Cbm
{
    public class GetRankCbm : CbmController
    {
        private static readonly DataAccessObject getDao = new GetRankDao();
        public ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            if (vo == null)
                return null;
            return getDao.Execute(trxContext, vo);
        }
    }
}