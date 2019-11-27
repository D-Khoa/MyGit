using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetAssetTypeDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            ValueObjectList<AssetMaster2019Vo> voList = new ValueObjectList<AssetMaster2019Vo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select distinct asset_type from m_asset order by asset_type");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while(datareader.Read())
            {
                AssetMaster2019Vo outVo = new AssetMaster2019Vo
                {
                    asset_type = datareader["asset_type"].ToString(),
                };
                voList.add(outVo);
            }
            datareader.Close();
            return voList;
        }
    }
}
