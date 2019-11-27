using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class AssetMaster2019Dao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            AssetMaster2019Vo inVo = (AssetMaster2019Vo)vo;
            StringBuilder sql = new StringBuilder();
            DataTable dt = new DataTable();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("SELECT asset_cd,asset_no,asset_name,asset_serial,asset_model,asset_life,acquistion_cost,acquistion_date,asset_invoice,asset_po,asset_type,factory_cd,asset_supplier,label_status from m_asset where 1=1 ");
            if (!string.IsNullOrEmpty(inVo.asset_cd))
                sql.Append("and asset_cd like '").Append(inVo.asset_cd).Append("%' ");
            if (!string.IsNullOrEmpty(inVo.asset_name))
                sql.Append("and asset_name like '").Append(inVo.asset_name).Append("%' ");
            if (!string.IsNullOrEmpty(inVo.asset_type))
                sql.Append("and asset_type like '").Append(inVo.asset_type).Append("%' ");
            if (!string.IsNullOrEmpty(inVo.asset_life))
                sql.Append("and asset_life like '").Append(inVo.asset_life).Append("%' ");
            if (inVo.checkDateFrom)
                sql.Append("and acquistion_date > '").Append(inVo.dateFrom.ToString("yyyy-MM-dd")).Append("' ");
            if (inVo.checkDateTo)
                sql.Append("and acquistion_date < '").Append(inVo.dateTo.ToString("yyyy-MM-dd")).Append("' ");
            sql.Append("order by asset_cd");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            dt.Load(datareader);
            datareader.Close();
            AssetMaster2019Vo outVo = new AssetMaster2019Vo
            {
                asset_data = dt
            };
            return outVo;
        }
    }
}