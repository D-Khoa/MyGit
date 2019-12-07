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
            AccountManagerVo inVo = (AccountManagerVo)vo;
            DataTable dt = new DataTable();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select b.asset_cd as \"Asset Code\", b.asset_no as \"Asset No\", b.asset_name as \"Asset Name\", b.asset_model as \"Asset Model\", b.asset_serial as \"Asset Serial\", b.asset_supplier as \"Asset Supplier\", ");
            sql.Append("b.asset_type as \"Asset Type\", a.qty as \"Qty\", c.unit_name as \"Unit\", e.account_code_name as \"Account Code\", d.rank_name as \"Rank\", ");
            sql.Append("f.account_location_cd as \"Section Code\", f.account_location_name as \"Section Name\", g.location_cd as \"Now Location\", ");
            sql.Append("b.asset_life as \"Life\", b.acquistion_date as \"Acquisition Date\", a.depreciation_start as \"Depreciation Start\", a.depreciation_end as \"Depreciation End\", ");
            sql.Append("b.acquistion_cost as \"Acquisition Cost\", a.monthly_depreciation as \"Monthly Depr\", a.current_depreciation as \"Current Depr\", a.accum_depreciation_now as \"Accum Depr\", a.net_value as \"Net Value\", ");
            sql.Append("a.registration_user_cd as \"Reg User\", a.registration_date_time as \"Reg Date\", a.comment_data as \"Comment\", ");
            sql.Append("h.invertory_time_name as \"Invertory Time\", b.asset_invoice as \"Invoice\", i.factory_name as \"Factory\", b.label_status as \"Label\" ");
            sql.Append("from t_account_main a left join m_asset b on a.asset_id = b.asset_id ");
            sql.Append("left join m_unit c on a.unit_id = c.unit_id ");
            sql.Append("left join m_rank d on a.rank_id = d.rank_id ");
            sql.Append("left join m_account_code e on a.account_code_id = e.account_code_id ");
            sql.Append("left join m_account_location f on a.account_location_id = f.account_location_id ");
            sql.Append("left join m_location g on a.location_id = g.location_id ");
            sql.Append("left join m_invertory_time h on a.invertory_time_id = h.invertory_time_id ");
            sql.Append("left join m_factory i on a.factory_cd = i.factory_cd ");
            sql.Append("where 1=1 ");
            if (inVo.list_account_cd.Length > 3)
            {
                sql.Append("and e.account_code_id in (").Append(inVo.list_account_cd).Append(") ");
                //sqlParameter.AddParameterString("account_code_id", inVo.list_account_cd);
            }
            if (inVo.list_account_location.Length > 3)
            {
                sql.Append("and f.account_location_id in (").Append(inVo.list_account_location).Append(") ");
                //sqlParameter.AddParameterString("account_location_id", inVo.list_account_location);
            }
            if (inVo.list_asset_invoice.Length > 3)
            {
                sql.Append("and b.asset_invoice in (").Append(inVo.list_asset_invoice).Append(") ");
                //sqlParameter.AddParameterString("asset_invoice", inVo.list_asset_invoice);
            }
            if (inVo.list_asset_label.Length > 3)
            {
                sql.Append("and b.label_status in (").Append(inVo.list_asset_label).Append(") ");
                //sqlParameter.AddParameterString("asset_label_status", inVo.list_asset_label);
            }
            if (inVo.list_asset_model.Length > 3)
            {
                sql.Append("and b.asset_model in (").Append(inVo.list_asset_model).Append(") ");
                //sqlParameter.AddParameterString("asset_model", inVo.list_asset_model);
            }
            if (inVo.list_asset_type.Length > 3)
            {
                sql.Append("and b.asset_type in (").Append(inVo.list_asset_type).Append(") ");
                //sqlParameter.AddParameterString("asset_type", inVo.list_asset_type);
            }
            if (inVo.list_factory.Length > 3)
            {
                sql.Append("and i.factory_cd in (").Append(inVo.list_factory).Append(") ");
                //sqlParameter.AddParameterString("factory_cd", inVo.list_factory);
            }
            if (inVo.list_invertory_times.Length > 3)
            {
                sql.Append("and h.invertory_time_id in (").Append(inVo.list_invertory_times).Append(") ");
                //sqlParameter.AddParameterString("invertory_time_id", inVo.list_invertory_times);
            }
            if (inVo.list_location.Length > 3)
            {
                sql.Append("and g.location_id in (").Append(inVo.list_location).Append(") ");
                //sqlParameter.AddParameterString("location_id", inVo.list_location);
            }
            if (inVo.list_rank.Length > 3)
            {
                sql.Append("and d.rank_id in (").Append(inVo.list_rank).Append(") ");
                //sqlParameter.AddParameterString("rank_id", inVo.list_rank);
            }
            if (inVo.list_unit.Length > 3)
            {
                sql.Append("and c.unit_id in (").Append(inVo.list_unit).Append(") ");
                //sqlParameter.AddParameterString("unit_id", inVo.list_unit);
            }
            if (!string.IsNullOrEmpty(inVo.asset_cd))
            {
                sql.Append("and b.asset_cd like '%").Append(inVo.asset_cd).Append("%' ");
                //sqlParameter.AddParameterString("asset_cd", inVo.asset_cd);
            }
            if (!string.IsNullOrEmpty(inVo.asset_name))
            {
                sql.Append("and b.asset_name like '%").Append(inVo.asset_name).Append("%' ");
                sqlParameter.AddParameterString("asset_name", inVo.asset_name);
            }
            if (inVo.value_expired)
                sql.Append("and a.net_value <= '0' ");
            if (inVo.value_valid)
                sql.Append("and a.net_value > '0' ");
            sql.Append("order by b.asset_cd");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            dt.Load(datareader);
            datareader.Close();
            AccountManagerVo outVo = new AccountManagerVo
            {
                table = dt
            };
            return outVo;
        }
    }
}
