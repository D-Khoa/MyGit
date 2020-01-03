using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetAccountLocationDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                StringBuilder query = new StringBuilder();
                AccountLocationVo inVo = (AccountLocationVo)vo;
                ValueObjectList<AccountLocationVo> listVo = new ValueObjectList<AccountLocationVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from m_account_location where 1=1 ");
                if (inVo.account_location_id > 0)
                    query.Append("and account_location_id='").Append(inVo.account_location_id).Append("' ");
                if (string.IsNullOrEmpty(inVo.account_location_cd))
                    query.Append("and account_location_cd='").Append(inVo.account_location_cd).Append("' ");
                if (string.IsNullOrEmpty(inVo.account_location_type))
                    query.Append("and account_location_type='").Append(inVo.account_location_type).Append("' ");
                query.Append("order by account_location_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    AccountLocationVo outVo = new AccountLocationVo
                    {
                        account_location_id = (int)datareader["account_location_id"],
                        account_location_cd = datareader["account_location_cd"].ToString(),
                        account_location_name = datareader["account_location_name"].ToString(),
                        account_location_type = datareader["account_location_type"].ToString(),
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
