using System;
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
            AccountInfoVo inVo = (AccountInfoVo)vo;
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("Select * from t_account_main where 1=1 ");
            sql.Append("and account_main_id ='").Append(inVo.account_main_id).Append("' ");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                inVo.asset_id = (int)datareader["asset_id"];
                inVo.qty = (int)datareader["qty"];
                inVo.unit_id = (int)datareader["unit_id"];
                inVo.account_code_id = (int)datareader["account_code_id"];
                inVo.account_location_id = (int)datareader["account_location_id"];
                inVo.rank_id = (int)datareader["rank_id"];
                inVo.comment_data = datareader["comment_data"].ToString();
                inVo.depreciation_start = (DateTime)datareader["depreciation_start"];
                inVo.depreciation_end = (DateTime)datareader["depreciation_end"];
                inVo.current_depreciation = (double)datareader["current_depreciation"];
                inVo.monthly_depreciation = (double)datareader["monthly_depreciation"];
                inVo.accum_depreciation = (double)datareader["accum_depreciation_now"];
                inVo.net_value = (double)datareader["net_value"];
                inVo.location_id = (int)datareader["location_id"];
                inVo.user_location_id = (int)datareader["user_location_id"];
                inVo.registration_user_cd = datareader["registration_user_cd"].ToString();
                inVo.registration_date_time = (DateTime)datareader["registration_date_time"];
                inVo.factory_cd = datareader["factory_cd"].ToString();
                inVo.invertory_time_id = (int)datareader["invertory_time_id"];
            }
            datareader.Close();
            return inVo;
        }
    }
}
