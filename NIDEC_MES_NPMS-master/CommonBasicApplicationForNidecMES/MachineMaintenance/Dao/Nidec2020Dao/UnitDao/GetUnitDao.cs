using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetUnitDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                UnitVo inVo = (UnitVo)vo;
                StringBuilder query = new StringBuilder();
                ValueObjectList<UnitVo> listVo = new ValueObjectList<UnitVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from m_unit where 1=1 ");
                if (inVo.unit_id > 0 || inVo != null)
                    query.Append("and unit_id='").Append(inVo.unit_id).Append("' ");
                if (string.IsNullOrEmpty(inVo.unit_cd))
                    query.Append("and unit_cd='").Append(inVo.unit_cd).Append("' ");
                query.Append("order by unit_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    UnitVo outVo = new UnitVo
                    {
                        unit_id = (int)datareader["unit_id"],
                        unit_cd = datareader["unit_cd"].ToString(),
                        unit_name = datareader["unit_name"].ToString(),
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
