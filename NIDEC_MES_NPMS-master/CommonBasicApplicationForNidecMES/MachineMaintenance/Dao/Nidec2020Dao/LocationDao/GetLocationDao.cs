using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetLocationDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                LocationVo inVo = (LocationVo)vo;
                StringBuilder query = new StringBuilder();
                ValueObjectList<LocationVo> listVo = new ValueObjectList<LocationVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from m_location where 1=1 ");
                if (inVo.location_id > 0 || inVo != null)
                    query.Append("and location_id='").Append(inVo.location_id).Append("' ");
                if (string.IsNullOrEmpty(inVo.location_cd))
                    query.Append("and location_cd='").Append(inVo.location_cd).Append("' ");
                query.Append("order by location_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    LocationVo outVo = new LocationVo
                    {
                        location_id = (int)datareader["location_id"],
                        location_cd = datareader["location_cd"].ToString(),
                        location_name = datareader["location_name"].ToString(),
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
