using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetAccountCodeDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                AccountCodeVo inVo = (AccountCodeVo)vo;
                StringBuilder query = new StringBuilder();
                ValueObjectList<AccountCodeVo> listVo = new ValueObjectList<AccountCodeVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from m_account_code where 1=1 ");
                if (inVo.account_code_id > 0 || inVo != null)
                    query.Append("and account_code_id='").Append(inVo.account_code_id).Append("' ");
                if (string.IsNullOrEmpty(inVo.account_code_cd))
                    query.Append("and account_code_cd='").Append(inVo.account_code_cd).Append("' ");
                query.Append("order by account_code_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    AccountCodeVo outVo = new AccountCodeVo
                    {
                        account_code_id = (int)datareader["account_code_id"],
                        account_code_cd = datareader["account_code_cd"].ToString(),
                        account_code_name = datareader["account_code_name"].ToString(),
                        registration_user_cd = datareader["registration_user_cd"].ToString(),
                        registration_date_time = (DateTime)datareader["registration_date_time"],
                        factory_cd = datareader["factory_cd"].ToString()
                    };
                    listVo.add(outVo);
                }
                //CLEAR AND CLOSE CONNECTION
                query.Clear();
                datareader.Close();
                base.CloseConnection(trxContext);
                return listVo;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
