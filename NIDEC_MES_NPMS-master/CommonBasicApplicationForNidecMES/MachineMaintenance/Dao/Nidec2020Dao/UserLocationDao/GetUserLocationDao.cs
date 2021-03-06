﻿using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetUserLocationDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                UserLocationVo inVo = (UserLocationVo)vo;
                StringBuilder query = new StringBuilder();
                ValueObjectList<UserLocationVo> listVo = new ValueObjectList<UserLocationVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from m_user_location where 1=1 ");
                if (inVo.user_location_id > 0 || inVo != null)
                    query.Append("and user_location_id='").Append(inVo.user_location_id).Append("' ");
                if (string.IsNullOrEmpty(inVo.user_location_cd))
                    query.Append("and user_location_cd='").Append(inVo.user_location_cd).Append("' ");
                query.Append("order by user_location_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    UserLocationVo outVo = new UserLocationVo
                    {
                        user_location_id = (int)datareader["user_location_id"],
                        user_location_cd = datareader["user_location_cd"].ToString(),
                        user_location_name = datareader["user_location_name"].ToString(),
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
