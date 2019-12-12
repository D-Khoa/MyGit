using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetAccountLocationDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            AccountLocationVo inVo = (AccountLocationVo)vo;
            ValueObjectList<AccountLocationVo> voList = new ValueObjectList<AccountLocationVo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select account_location_id,account_location_cd,account_location_name from m_account_location where 1=1 ");
            if (!string.IsNullOrEmpty(inVo.account_location_cd))
                sql.Append("and account_location_cd='").Append(inVo.account_location_cd).Append("' ");
            if (!string.IsNullOrEmpty(inVo.account_location_name))
                sql.Append("and account_location_name='").Append(inVo.account_location_name).Append("' ");
            sql.Append("order by account_location_id");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                AccountLocationVo outVo = new AccountLocationVo
                {
                    account_location_id = (int)datareader["account_location_id"],
                    account_location_cd = datareader["account_location_cd"].ToString(),
                    account_location_name = datareader["account_location_name"].ToString()
                };
                voList.add(outVo);
            }
            datareader.Close();
            return voList;
        }
    }
}
