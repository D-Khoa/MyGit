using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetLocationInfoDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            LocationInfoVo inVo = (LocationInfoVo)vo;
            ValueObjectList<LocationInfoVo> voList = new ValueObjectList<LocationInfoVo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select distinct location_id, location_cd, location_name from m_location where 1=1 ");
            if (!string.IsNullOrEmpty(inVo.location_cd))
                sql.Append("and location_cd='").Append(inVo.location_cd).Append("' ");
            if (!string.IsNullOrEmpty(inVo.location_name))
                sql.Append("and location_name='").Append(inVo.location_name).Append("' ");
            sql.Append("order by location_id");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                LocationInfoVo outVo = new LocationInfoVo
                {
                    location_id = (int)datareader["location_id"],
                    location_cd = datareader["location_cd"].ToString(),
                    location_name = datareader["location_name"].ToString()
                };
                voList.add(outVo);
            }
            datareader.Close();
            return voList;
        }
    }
}
