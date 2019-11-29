using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class UpdateAssetDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            AssetInfoVo inVo = (AssetInfoVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("update m_asset set asset_cd=:asset_cd,asset_no=:asset_no,asset_name=:asset_name, asset_model=:asset_model, asset_invoice =:asset_invoice,  asset_serial =:asset_serial, asset_supplier=:asset_supplier,asset_life =:asset_life, acquistion_date=:acquistion_date, acquistion_cost=:acquistion_cost, asset_type=:asset_type, label_status=:label_status, asset_po = :asset_po");
            sql.Append(" where asset_cd =:asset_cd and asset_no = :asset_no");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameterInteger("asset_no", inVo.asset_no);
            sqlParameter.AddParameterString("asset_cd", inVo.asset_cd);
            sqlParameter.AddParameterString("asset_name", inVo.asset_name);
            sqlParameter.AddParameterString("asset_model", inVo.asset_model);
            sqlParameter.AddParameterString("asset_serial", inVo.asset_serial);
            sqlParameter.AddParameterString("asset_supplier", inVo.asset_supplier);
            sqlParameter.AddParameterString("asset_invoice", inVo.asset_invoice);
            sqlParameter.AddParameter("asset_life", inVo.asset_life);
            sqlParameter.AddParameterDateTime("acquistion_date", inVo.acquistion_date);
            sqlParameter.AddParameter("acquistion_cost", inVo.acquistion_cost);
            sqlParameter.AddParameterString("asset_type", inVo.asset_type);
            sqlParameter.AddParameterString("factory_cd", inVo.factory_cd);
            sqlParameter.AddParameterString("registration_user_cd", UserData.GetUserData().UserCode);
            sqlParameter.AddParameterString("label_status", inVo.label_status);
            sqlParameter.AddParameterString("asset_po", inVo.asset_po);

            //execute SQL
            AssetMaster2019Vo outVo = new AssetMaster2019Vo()
            {
                executeInt = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };
            return outVo;
        }
    }
}
