using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetAccountInfoDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            AccountManagerVo inVo = new AccountManagerVo();
            ValueObjectList<AccountInfoVo> voList = new ValueObjectList<AccountInfoVo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select * from m_account");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                AccountInfoVo outVo = new AccountInfoVo
                {
                    asset_model = datareader["asset_model"].ToString(),
                    asset_type = datareader["asset_type"].ToString(),
                    asset_invoice = datareader["asset_invoice"].ToString(),
                    label_status = datareader["label_status"].ToString()
                };
                voList.add(outVo);
            }
            datareader.Close();
            return voList;
        }
    }
}
