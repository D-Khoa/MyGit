using System;
using Com.Nidec.Mes.Framework;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2020Vo
{
    public class InventoryEquipmentsVo : ValueObject
    {
        public int inventory_equipments_id { get; set; }
        public int warehouse_main_id { get; set; }
        public int location_id { get; set; }
        public int inventory_time_id { get; set; }
        public bool inventory_value { get; set; }
        public string registration_user_cd { get; set; }
        public DateTime registration_date_time { get; set; }
        public string factory_cd { get; set; }
    }
}
