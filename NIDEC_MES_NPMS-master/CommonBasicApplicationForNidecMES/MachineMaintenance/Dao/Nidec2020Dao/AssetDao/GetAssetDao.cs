using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetAssetDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                AssetVo inVo = (AssetVo)vo;
                StringBuilder query = new StringBuilder();
                ValueObjectList<AssetVo> listVo = new ValueObjectList<AssetVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from m_asset where 1=1 ");
                if (inVo.asset_id > 0 || inVo != null)
                    query.Append("and asset_id='").Append(inVo.asset_id).Append("' ");
                if (inVo.asset_no > 0 || inVo != null)
                    query.Append("and asset_no='").Append(inVo.asset_no).Append("' ");
                if (string.IsNullOrEmpty(inVo.asset_cd))
                    query.Append("and asset_cd='").Append(inVo.asset_cd).Append("' ");
                if (string.IsNullOrEmpty(inVo.asset_name))
                    query.Append("and asset_name='").Append(inVo.asset_name).Append("' ");
                if (string.IsNullOrEmpty(inVo.asset_model))
                    query.Append("and asset_model='").Append(inVo.asset_model).Append("' ");
                if (string.IsNullOrEmpty(inVo.asset_serial))
                    query.Append("and asset_serial='").Append(inVo.asset_serial).Append("' ");
                if (string.IsNullOrEmpty(inVo.asset_supplier))
                    query.Append("and asset_supplier='").Append(inVo.asset_supplier).Append("' ");
                if (string.IsNullOrEmpty(inVo.asset_invoice))
                    query.Append("and asset_invoice='").Append(inVo.asset_invoice).Append("' ");
                if (inVo.asset_life > 0 || inVo != null)
                    query.Append("and asset_life='").Append(inVo.asset_life).Append("' ");
                if (string.IsNullOrEmpty(inVo.asset_type))
                    query.Append("and asset_type='").Append(inVo.asset_type).Append("' ");
                query.Append("order by asset_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    AssetVo outVo = new AssetVo
                    {
                        asset_id = (int)datareader["asset_id"],
                        asset_no = (int)datareader["asset_no"],
                        asset_cd = datareader["asset_cd"].ToString(),
                        asset_name = datareader["asset_name"].ToString(),
                        asset_model = datareader["asset_model"].ToString(),
                        asset_serial = datareader["asset_serial"].ToString(),
                        asset_supplier = datareader["asset_supplier"].ToString(),
                        asset_invoice = datareader["asset_invoice"].ToString(),
                        asset_life = (double)datareader["asset_life"],
                        acquistion_date = (DateTime)datareader["acquistion_date"],
                        acquistion_cost = (double)datareader["acquistion_cost"],
                        asset_type = datareader["asset_type"].ToString(),
                        asset_po = datareader["asset_po"].ToString(),
                        label_status = datareader["label_status"].ToString(),
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
