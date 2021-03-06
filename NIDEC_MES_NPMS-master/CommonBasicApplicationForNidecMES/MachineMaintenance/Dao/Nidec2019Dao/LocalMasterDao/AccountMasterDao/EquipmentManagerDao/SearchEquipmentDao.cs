﻿using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class SearchEquipmentDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            EquipmentManagerVo inVo = (EquipmentManagerVo)vo;
            DataTable dt = new DataTable();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select a.warehouse_main_id as \"Warehouse_ID\", ");
            sql.Append("b.asset_cd as \"Asset_Code\", b.asset_no as \"Asset_No\", b.asset_name as \"Asset_Name\", ");
            sql.Append("b.asset_model as \"Asset_Model\", b.asset_serial as \"Asset_Serial\", ");
            sql.Append("b.asset_supplier as \"Asset_Supplier\", b.asset_type as \"Asset_Type\", ");
            sql.Append("a.qty as \"Qty\", c.unit_name as \"Unit\", ");
            sql.Append("e.account_code_name as \"Account_Code\", d.rank_name as \"Rank\", ");
            sql.Append("f.account_location_cd as \"Section_Code\", f.account_location_name as \"Section_Name\", ");
            sql.Append("g.location_cd as \"Before_Location\", k.location_cd as \"After_Location\", ");
            sql.Append("g.location_cd as \"Now_Location\", ");
            sql.Append("b.asset_life as \"Life\", b.acquistion_date as \"Acquisition_Date\", ");
            sql.Append("a.depreciation_start as \"Depreciation_Start\", a.depreciation_end as \"Depreciation_End\", ");
            sql.Append("b.acquistion_cost as \"Acquisition_Cost\", a.monthly_depreciation as \"Monthly_Depr\", ");
            sql.Append("a.current_depreciation as \"Current_Depr\", a.accum_depreciation_now as \"Accum_Depr\", ");
            sql.Append("a.net_value as \"Net_Value\", ");
            sql.Append("j.user_location_name as \"User_Location\", a.comment_data as \"Comment\", ");
            sql.Append("a.registration_date_time as \"Reg_Date\", a.registration_user_cd as \"Reg_User\", ");
            sql.Append("b.asset_invoice as \"Invoice\", b.label_status as \"Label\", ");
            sql.Append("h.invertory_time_name as \"Inventory_Time\", i.factory_name as \"Factory\" ");
            sql.Append("from t_warehouse_main a left join m_asset b on a.asset_id = b.asset_id ");
            sql.Append("left join m_unit c on a.unit_id = c.unit_id ");
            sql.Append("left join m_rank d on a.rank_id = d.rank_id ");
            sql.Append("left join m_account_code e on a.account_code_id = e.account_code_id ");
            sql.Append("left join m_account_location f on a.account_location_id = f.account_location_id ");
            sql.Append("left join m_location g on a.before_location_id = g.location_id ");
            sql.Append("left join m_location k on a.after_location_id = k.location_id ");
            sql.Append("left join t_invertory_equipments l on a.warehouse_main_id = l.warehouse_main_id ");
            sql.Append("left join m_location m on l.location_id = m.location_id ");
            sql.Append("left join m_invertory_time h on a.invertory_time_id = h.invertory_time_id ");
            sql.Append("left join m_factory i on a.factory_cd = i.factory_cd ");
            sql.Append("left join m_user_location j on a.user_location_id = j.user_location_id ");
            sql.Append("where 1=1 ");
            if (inVo.list_account_cd.Length > 3)
            {
                sql.Append("and e.account_code_id in (").Append(inVo.list_account_cd).Append(") ");
            }
            if (inVo.list_account_location.Length > 3)
            {
                sql.Append("and f.account_location_id in (").Append(inVo.list_account_location).Append(") ");
            }
            if (inVo.list_asset_invoice.Length > 3)
            {
                sql.Append("and b.asset_invoice in (").Append(inVo.list_asset_invoice).Append(") ");
            }
            if (inVo.list_asset_label.Length > 3)
            {
                sql.Append("and b.label_status in (").Append(inVo.list_asset_label).Append(") ");
            }
            if (inVo.list_asset_model.Length > 3)
            {
                sql.Append("and b.asset_model in (").Append(inVo.list_asset_model).Append(") ");
            }
            if (inVo.list_asset_type.Length > 3)
            {
                sql.Append("and b.asset_type in (").Append(inVo.list_asset_type).Append(") ");
            }
            if (inVo.list_factory.Length > 3)
            {
                sql.Append("and i.factory_cd in (").Append(inVo.list_factory).Append(") ");
            }
            if (inVo.list_invertory_times.Length > 3)
            {
                sql.Append("and h.invertory_time_id in (").Append(inVo.list_invertory_times).Append(") ");
            }
            if (inVo.list_location.Length > 3)
            {
                sql.Append("and g.location_id in (").Append(inVo.list_location).Append(") ");
            }
            if (inVo.list_rank.Length > 3)
            {
                sql.Append("and d.rank_id in (").Append(inVo.list_rank).Append(") ");
            }
            if (inVo.list_unit.Length > 3)
            {
                sql.Append("and c.unit_id in (").Append(inVo.list_unit).Append(") ");
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
            return inVo;
        }
    }
}
