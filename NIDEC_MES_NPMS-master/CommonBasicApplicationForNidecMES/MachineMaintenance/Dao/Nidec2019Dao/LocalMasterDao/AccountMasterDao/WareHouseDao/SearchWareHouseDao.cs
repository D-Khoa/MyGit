using System;
using System.Text;
using Com.Nidec.Mes.Framework;
using System.Data;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class SearchWareHouseDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WareHouseVo inVo = (WareHouseVo)vo;
            DataTable dt = new DataTable();
            StringBuilder sql = new StringBuilder();
            ValueObjectList<WareHouseVo> voList = new ValueObjectList<WareHouseVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append(@"select m.invertory_time_cd,  m.invertory_time_id, k.unit_name, d.user_location_name,g.account_main_id,c.location_cd,e.asset_cd, e.asset_no, e.asset_name, e.asset_model, e.asset_serial, e.asset_supplier,e.asset_po, g.qty, a.account_code_cd, b.account_location_cd, f.rank_cd, b.account_location_name, g.comment_data, e.asset_life, e.acquistion_date, e.acquistion_cost, e.asset_type, g.depreciation_start, g.depreciation_end, g.current_depreciation,g.monthly_depreciation, g.accum_depreciation_now, g.net_value, e.asset_invoice, g.registration_date_time, g.registration_user_cd, e.label_status from t_account_main g
                           left join m_account_code a on a.account_code_id = g.account_code_id
                           left join m_account_location b on b.account_location_id = g.account_location_id
                            left join m_location c on c.location_id = g.location_id
                            left join m_user_location d on d.user_location_id = g.user_location_id
                            left join m_asset e on e.asset_id = g.asset_id
                            left join m_rank f on f.rank_id = g.rank_id
                            left join m_unit k on k.unit_id = g.unit_id
                             left join t_warehouse_main u on u.asset_id = g.asset_id
                            left join t_invertory_equipments l on l.warehouse_main_id = u.warehouse_main_id
                            left join m_invertory_time m on m.invertory_time_id = l.invertory_time_id
                      where 1=1  ");


            if (!String.IsNullOrEmpty(inVo.asset_code))
            {
                sql.Append(@" and   e.asset_cd  =:asset_cd");
                sqlParameter.AddParameterString("asset_cd", inVo.asset_code);
            }
            if (!String.IsNullOrEmpty(inVo.rank))
            {
                sql.Append(" and f.rank_cd  =:rank_cd");
                sqlParameter.AddParameterString("rank_cd", inVo.rank);
            }

            if (!String.IsNullOrEmpty(inVo.asset_model))
            {
                sql.Append(" and e.asset_model =:asset_model");
                sqlParameter.AddParameterString("asset_model", inVo.asset_model);
            }
            if (!String.IsNullOrEmpty(inVo.asset_name))
            {
                sql.Append(" and e.asset_name =:asset_name");
                sqlParameter.AddParameterString("asset_name", inVo.asset_name);
            }
            if (!String.IsNullOrEmpty(inVo.asset_name))
            {
                sql.Append(" and e.asset_type =:asset_type");
                sqlParameter.AddParameterString("asset_type", inVo.asset_type);
            }
            if (!String.IsNullOrEmpty(inVo.invoice))
            {
                sql.Append(" and e.asset_invoice =:asset_invoice");
                sqlParameter.AddParameterString("asset_invoice", inVo.invoice);
            }
            if (!String.IsNullOrEmpty(inVo.location))
            {
                sql.Append(" and c.location_cd =:location_cd");
                sqlParameter.AddParameterString("location_cd", inVo.location);
            }
            if (!String.IsNullOrEmpty(inVo.label_status))//label status
            {
                sql.Append(" and e.label_status =:label_status");
                sqlParameter.AddParameterString("label_status", inVo.label_status);
            }
            //if (!String.IsNullOrEmpty(inVo.li))//label status
            //{
            //    sql.Append(" and e.asset_po =:asset_po");
            //    sqlParameter.AddParameterString("asset_po", inVo.AssetPO);
            //}
            if (!String.IsNullOrEmpty(inVo.net_value))//search theo net value
            {
                if (inVo.net_value == "0$")
                {
                    sql.Append(" and g.net_value = 0");
                }
                else if (inVo.net_value == "1$")
                {
                    sql.Append(" and g.net_value > 0 and g.net_value <2 ");
                }
            }
            sql.Append(" and l.invertory_equipments_id in (select max(invertory_equipments_id) from t_invertory_equipments group by warehouse_main_id) ");
            sql.Append(" order by  g.registration_date_time desc");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());


            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            dt.Load(dataReader);
            dataReader.Close();
            WareHouseVo outVo = new WareHouseVo
            {
                table = dt
            };

            return outVo;
        }

    }
}
