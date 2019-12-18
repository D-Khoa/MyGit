using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetAccountCodeDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            AccountCodeVo inVo = (AccountCodeVo)vo;
            ValueObjectList<AccountCodeVo> voList = new ValueObjectList<AccountCodeVo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select account_code_id, account_code_cd, account_code_name from m_account_code where 1=1 ");
            if (!string.IsNullOrEmpty(inVo.account_code_cd))
                sql.Append("and account_code_cd='").Append(inVo.account_code_cd).Append("' ");
            if (!string.IsNullOrEmpty(inVo.account_code_name))
                sql.Append("and account_code_name='").Append(inVo.account_code_name).Append("' ");
            sql.Append("order by account_code_id");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                AccountCodeVo outVo = new AccountCodeVo
                {
                    account_code_id = (int)datareader["account_code_id"],
                    account_code_cd = datareader["account_code_cd"].ToString(),
                    account_code_name = datareader["account_code_name"].ToString()
                };
                voList.add(outVo);
            }
            datareader.Close();
            base.CloseConnection(trxContext);
            return voList;
        }
    }
}
