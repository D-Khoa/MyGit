using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetAccountWHDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                AccountWHVo inVo = (AccountWHVo)vo;
                StringBuilder query = new StringBuilder();
                ValueObjectList<AccountWHVo> listVo = new ValueObjectList<AccountWHVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from t_warehouse_main where 1=1 ");
                if (inVo.warehouse_main_id > 0 || inVo != null)
                    query.Append("and warehouse_main_id='").Append(inVo.warehouse_main_id).Append("' ");
                if (inVo.asset_id > 0 || inVo != null)
                    query.Append("and asset_id='").Append(inVo.asset_id).Append("' ");
                if (inVo.unit_id > 0 || inVo != null)
                    query.Append("and unit_id='").Append(inVo.unit_id).Append("' ");
                if (inVo.account_code_id > 0 || inVo != null)
                    query.Append("and account_code_id='").Append(inVo.account_code_id).Append("' ");
                if (inVo.account_location_id > 0 || inVo != null)
                    query.Append("and account_location_id='").Append(inVo.account_location_id).Append("' ");
                if (inVo.rank_id > 0 || inVo != null)
                    query.Append("and rank_id='").Append(inVo.rank_id).Append("' ");
                if (inVo.before_location_id > 0 || inVo != null)
                    query.Append("and before_location_id='").Append(inVo.before_location_id).Append("' ");
                if (inVo.after_location_id > 0 || inVo != null)
                    query.Append("and after_location_id='").Append(inVo.after_location_id).Append("' ");
                if (inVo.user_location_id > 0 || inVo != null)
                    query.Append("and user_location_id='").Append(inVo.user_location_id).Append("' ");
                if (inVo.detail_position_id > 0 || inVo != null)
                    query.Append("and detail_position_id='").Append(inVo.detail_position_id).Append("' ");
                query.Append("order by user_location_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    AccountWHVo outVo = new AccountWHVo
                    {
                        warehouse_main_id = (int)datareader["warehouse_main_id"],
                        asset_id = (int)datareader["asset_id"],
                        qty = (int)datareader["qty"],
                        unit_id = (int)datareader["unit_id"],
                        account_code_id = (int)datareader["account_code_id"],
                        account_location_id = (int)datareader["account_location_id"],
                        rank_id = (int)datareader["rank_id"],
                        comment_data = datareader["comment_data"].ToString(),
                        depreciation_start = (DateTime)datareader["depreciation_start"],
                        depreciation_end = (DateTime)datareader["depreciation_end"],
                        current_depreciation = (double)datareader["current_depreciation"],
                        monthly_depreciation = (double)datareader["monthly_depreciation"],
                        accum_depreciation_now = (double)datareader["accum_depreciation_now"],
                        net_value = (double)datareader["net_value"],
                        before_location_id = (int)datareader["before_location_id"],
                        after_location_id = (int)datareader["after_location_id"],
                        user_location_id = (int)datareader["user_location_id"],
                        detail_position_id = (int)datareader["detail_position_id"],
                        inventory_time_id = (int)datareader["invertory_time_id"],
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
