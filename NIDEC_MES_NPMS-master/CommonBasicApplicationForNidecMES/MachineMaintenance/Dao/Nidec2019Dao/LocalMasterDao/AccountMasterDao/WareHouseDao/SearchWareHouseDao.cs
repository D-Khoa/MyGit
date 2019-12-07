using System;
using System.Text;
using Com.Nidec.Mes.Framework;

using System.Data;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
  public  class SearchWareHouseDao :  AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            WareHouseVo inVo = (WareHouseVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<WareHouseVo> voList = new ValueObjectList<WareHouseVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append(@"select k.unit_name,c.location_cd as before, j.location_cd as after, h.detail_postion_cd, d.user_location_name ,g.warehouse_main_history_id,c.location_cd,e.asset_cd, e.asset_no, e.asset_name, e.asset_model, e.asset_serial, e.asset_supplier,e.asset_po, e.asset_invoice,e.label_status, g.qty, a.account_code_cd, b.account_location_cd, f.rank_cd, b.account_location_name, g.comment_data, e.asset_life, e.acquistion_date, e.acquistion_cost, e.asset_type, g.depreciation_start, g.depreciation_end, g.current_depreciation,g.monthly_depreciation, g.accum_depreciation_now, g.net_value, g.registration_date_time, g.registration_user_cd from t_warehouse_main_history g
                           left join m_account_code a on a.account_code_id = g.account_code_id
                           left join m_account_location b on b.account_location_id = g.account_location_id
                            left join m_location c on c.location_id = g.before_location_id
                            left join m_location j on j.location_id = g.after_location_id
                            left join m_user_location d on d.user_location_id = g.user_location_id
                            left join m_asset e on e.asset_id = g.asset_id
                            left join m_rank f on f.rank_id = g.rank_id
                            left join m_detail_postion h on h.detail_postion_id = g.detail_position_id
                            left join m_unit k on k.unit_id = g.unit_id
                      where 1=1  ");

            if (!String.IsNullOrEmpty(inVo.asset_cd))
            {
                sql.Append(@" and   e.asset_cd  =:asset_cd");
                sqlParameter.AddParameterString("asset_cd", inVo.asset_cd);
            }
            if (!String.IsNullOrEmpty(inVo.rank_cd))
            {
                sql.Append(" and f.rank_cd  =:rank_cd");
                sqlParameter.AddParameterString("rank_cd", inVo.rank_cd);
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
            if (!String.IsNullOrEmpty(inVo.asset_type))
            {
                sql.Append(" and e.asset_type =:asset_type");
                sqlParameter.AddParameterString("asset_type", inVo.asset_type);
            }
            if (!String.IsNullOrEmpty(inVo.asset_invoice))
            {
                sql.Append(" and e.asset_invoice =:asset_invoice");
                sqlParameter.AddParameterString("asset_invoice", inVo.asset_invoice);
            }

            if (!String.IsNullOrEmpty(inVo.location_cd))
            {
                sql.Append(" and j.location_cd =:location_cd");
                sqlParameter.AddParameterString("location_cd", inVo.location_cd);
            }
            //if (!String.IsNullOrEmpty(inVo.DetailPositionCd))
            //{
            //    sql.Append(" and h.detail_postion_cd =:detail_postion_cd");
            //    sqlParameter.AddParameterString("detail_postion_cd", inVo.DetailPositionCd);
            //}
            if (!String.IsNullOrEmpty(inVo.label_status))//label status
            {
                sql.Append(" and e.label_status =:label_status");
                sqlParameter.AddParameterString("label_status", inVo.label_status);
            }
            //if (!String.IsNullOrEmpty(inVo.AssetPO))//label status
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

            sql.Append(" order by  g.registration_date_time desc");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());


            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                WareHouseVo outVo = new WareHouseVo
                {
                    //  , h., i., k., o.prodution_work_content_name
                    WareHouseMainId = int.Parse(dataReader["warehouse_main_history_id"].ToString()),
                    AfterLocationCd = dataReader["after"].ToString(),
                    BeforeLocationCd = dataReader["before"].ToString(),
                    DetailPositionCd = dataReader["detail_postion_cd"].ToString(),
                    AssetCode = dataReader["asset_cd"].ToString(),
                    AssetNo = int.Parse(dataReader["asset_no"].ToString()),
                    AssetName = dataReader["asset_name"].ToString(),
                    AssetModel = dataReader["asset_model"].ToString(),
                    AssetSerial = dataReader["asset_serial"].ToString(),
                    AssetSupplier = dataReader["asset_supplier"].ToString(),
                    QTY = int.Parse(dataReader["qty"].ToString()),
                    UnitName = dataReader["unit_name"].ToString(),
                    UserLocationName = dataReader["user_location_name"].ToString(),
                    AccountCodeCode = dataReader["account_code_cd"].ToString(),
                    AccountLocationCode = dataReader["account_location_cd"].ToString(),
                    RankCode = dataReader["rank_cd"].ToString(),
                    AccountLocationName = dataReader["account_location_name"].ToString(),
                    CommnetsData = dataReader["comment_data"].ToString(),
                    AssetLife = int.Parse(dataReader["asset_life"].ToString()),
                    AcquisitionDate = DateTime.Parse(dataReader["acquistion_date"].ToString()),
                    AcquisitionCost = double.Parse(dataReader["acquistion_cost"].ToString()),
                    StartDepreciation = DateTime.Parse(dataReader["depreciation_start"].ToString()),
                    EndDepreciation = DateTime.Parse(dataReader["depreciation_end"].ToString()),
                    CurrentDepreciation = double.Parse(dataReader["current_depreciation"].ToString()),
                    MonthlyDepreciation = double.Parse(dataReader["monthly_depreciation"].ToString()),
                    AccumDepreciation = double.Parse(dataReader["accum_depreciation_now"].ToString()),
                    NetValue = double.Parse(dataReader["net_value"].ToString()),
                    AssetType = dataReader["asset_type"].ToString(),
                    AssetInvoice = (dataReader["asset_invoice"].ToString()),
                    LabelStatus = (dataReader["label_status"].ToString()),
                    AssetPO = dataReader["asset_po"].ToString(),
                    RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                    RegistrationUserCode = (dataReader["registration_user_cd"].ToString()),


                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
