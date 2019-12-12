using System;
using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetAssetInfoDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            AssetInfoVo inVo = (AssetInfoVo)vo;
            ValueObjectList<AssetInfoVo> voList = new ValueObjectList<AssetInfoVo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select * from m_asset where 1=1 ");
            if (inVo.asset_id > 0)
                sql.Append("and asset_id='").Append(inVo.asset_id).Append("' ");
            if (!string.IsNullOrEmpty(inVo.asset_cd))
                sql.Append("and asset_cd='").Append(inVo.asset_cd).Append("' ");
            if (inVo.asset_no > 0)
                sql.Append("and asset_no='").Append(inVo.asset_no).Append("' ");
            if (!string.IsNullOrEmpty(inVo.asset_name))
                sql.Append("and asset_name='").Append(inVo.asset_name).Append("' ");
            if (!string.IsNullOrEmpty(inVo.asset_type))
                sql.Append("and asset_type='").Append(inVo.asset_type).Append("' ");
            if (!string.IsNullOrEmpty(inVo.label_status))
                sql.Append("and label_status='").Append(inVo.label_status).Append("' ");
            sql.Append("order by asset_id");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                AssetInfoVo outVo = new AssetInfoVo
                {
                    asset_id = (int)datareader["asset_id"],
                    asset_cd = datareader["asset_cd"].ToString(),
                    asset_no = (int)datareader["asset_no"],
                    asset_name = datareader["asset_name"].ToString(),
                    asset_model = datareader["asset_model"].ToString(),
                    asset_serial = datareader["asset_serial"].ToString(),
                    acquistion_cost = (double)datareader["acquistion_cost"],
                    acquistion_date = (DateTime)datareader["acquistion_date"],
                    asset_life = (double)datareader["asset_life"],
                    asset_type = datareader["asset_type"].ToString(),
                    asset_invoice = datareader["asset_invoice"].ToString(),
                    asset_supplier = datareader["asset_supplier"].ToString(),
                    factory_cd = datareader["factory_cd"].ToString(),
                    label_status = datareader["label_status"].ToString(),
                    asset_po = datareader["asset_po"].ToString(),
                    registration_user_cd = datareader["registration_user_cd"].ToString(),
                    registration_date_time = (DateTime)datareader["registration_date_time"],
                };
                voList.add(outVo);
            }
            datareader.Close();
            return voList;
        }
    }
}
