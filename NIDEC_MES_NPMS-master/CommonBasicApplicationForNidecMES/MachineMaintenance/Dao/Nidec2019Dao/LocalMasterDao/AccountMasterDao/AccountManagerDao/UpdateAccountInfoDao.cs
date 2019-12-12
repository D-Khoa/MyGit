using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class UpdateAccountInfoDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            AccountInfoVo inVo = (AccountInfoVo)vo;
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("UPDATE t_account_main SET asset_id='").Append(inVo.asset_id).Append("', ");
            sql.Append("qty='").Append(inVo.qty).Append("', unit_id='").Append(inVo.unit_id).Append("', ");
            sql.Append("account_code_id='").Append(inVo.account_code_id).Append("', ");
            sql.Append("account_location_id='").Append(inVo.account_location_id).Append("', ");
            sql.Append("rank_id='").Append(inVo.rank_id).Append("', comment_data='").Append(inVo.comment_data).Append("', ");
            sql.Append("depreciation_start='").Append(inVo.depreciation_start).Append("', ");
            sql.Append("depreciation_end='").Append(inVo.depreciation_end).Append("', ");
            sql.Append("current_depreciation='").Append(inVo.current_depreciation).Append("', ");
            sql.Append("monthly_depreciation='").Append(inVo.monthly_depreciation).Append("', ");
            sql.Append("accum_depreciation_now='").Append(inVo.accum_depreciation).Append(", ");
            sql.Append("net_value='").Append(inVo.net_value).Append(", ");
            sql.Append("location_id='").Append(inVo.location_id).Append(", ");
            sql.Append("user_location_id='").Append(inVo.user_location_id).Append(", ");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            inVo.update = sqlCommandAdapter.ExecuteNonQuery(sqlParameter);
            return inVo;
        }
    }
}
