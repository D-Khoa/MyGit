using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetDetailPositionDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                DetailPositionVo inVo = (DetailPositionVo)vo;
                StringBuilder query = new StringBuilder();
                ValueObjectList<DetailPositionVo> listVo = new ValueObjectList<DetailPositionVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from m_detail_postion where 1=1 ");
                if (inVo.detail_postion_id > 0 || inVo != null)
                    query.Append("and detail_postion_id='").Append(inVo.detail_postion_id).Append("' ");
                if (string.IsNullOrEmpty(inVo.detail_postion_cd))
                    query.Append("and detail_postion_cd='").Append(inVo.detail_postion_cd).Append("' ");
                query.Append("order by detail_postion_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    DetailPositionVo outVo = new DetailPositionVo
                    {
                        detail_postion_id = (int)datareader["detail_postion_id"],
                        location_id = (int)datareader["location_id"],
                        detail_postion_cd = datareader["detail_postion_cd"].ToString(),
                        detail_postion_name = datareader["detail_postion_name"].ToString(),
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
