using System;
using System.Data;
using System.Text;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2020Dao
{
    public class GetInventoryEquipmentsDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            try
            {
                //VARIABLE
                InventoryEquipmentsVo inVo = (InventoryEquipmentsVo)vo;
                StringBuilder query = new StringBuilder();
                ValueObjectList<InventoryEquipmentsVo> listVo = new ValueObjectList<InventoryEquipmentsVo>();
                //CREATE SQL ADAPTER AND PARAMETER LIST
                DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
                //QUERY STRING
                query.Append("Select * from t_invertory_equipments where 1=1 ");
                if (inVo.inventory_equipments_id > 0 || inVo != null)
                    query.Append("and invertory_equipments_id='").Append(inVo.inventory_equipments_id)
                         .Append("' ");
                if (inVo.warehouse_main_id > 0 || inVo != null)
                    query.Append("and warehouse_main_id='").Append(inVo.warehouse_main_id).Append("' ");
                if (inVo.location_id > 0 || inVo != null)
                    query.Append("and location_id='").Append(inVo.location_id).Append("' ");
                if (inVo.inventory_time_id > 0 || inVo != null)
                    query.Append("and invertory_time_id='").Append(inVo.inventory_time_id).Append("' ");
                query.Append("order by invertory_equipments_id");
                //GET SQL ADAPTER
                sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, query.ToString());
                //EXECUTE READER FROM COMMAND
                IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
                while (datareader.Read())
                {
                    InventoryEquipmentsVo outVo = new InventoryEquipmentsVo
                    {
                        inventory_equipments_id = (int)datareader["invertory_equipments_id"],
                        warehouse_main_id = (int)datareader["warehouse_main_id"],
                        location_id = (int)datareader["location_id"],
                        inventory_time_id = (int)datareader["invertory_time_id"],
                        inventory_value = (bool)datareader["invertory_time_id"],
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
