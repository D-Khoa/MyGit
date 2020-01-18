using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetInventoryTimeDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                InventoryTimeVo inVo = (InventoryTimeVo)vo;
                StringBuilder query = new StringBuilder();
                ValueObjectList<InventoryTimeVo> listVo = new ValueObjectList<InventoryTimeVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from m_invertory_time where 1=1 ");
                if (inVo.inventory_time_id > 0 || inVo != null)
                    query.Append("and invertory_time_id='").Append(inVo.inventory_time_id).Append("' ");
                if (string.IsNullOrEmpty(inVo.inventory_time_cd))
                    query.Append("and invertory_time_cd='").Append(inVo.inventory_time_cd).Append("' ");
                query.Append("order by invertory_time_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    InventoryTimeVo outVo = new InventoryTimeVo
                    {
                        inventory_time_id = (int)datareader["invertory_time_id"],
                        inventory_time_cd = datareader["invertory_time_cd"].ToString(),
                        inventory_time_name = datareader["invertory_time_name"].ToString(),
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
