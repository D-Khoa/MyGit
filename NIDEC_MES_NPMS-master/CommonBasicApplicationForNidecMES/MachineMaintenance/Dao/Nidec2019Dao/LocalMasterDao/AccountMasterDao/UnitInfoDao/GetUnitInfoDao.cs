using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetUnitInfoDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            UnitInfoVo inVo = (UnitInfoVo)vo;
            ValueObjectList<UnitInfoVo> voList = new ValueObjectList<UnitInfoVo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select unit_id, unit_cd, unit_name from m_unit where 1=1 ");
            if (!string.IsNullOrEmpty(inVo.unit_cd))
                sql.Append("unit_cd='").Append(inVo.unit_cd).Append("' ");
            if (!string.IsNullOrEmpty(inVo.unit_name))
                sql.Append("unit_name='").Append(inVo.unit_name).Append("' ");
            sql.Append("order by unit_id");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                UnitInfoVo outVo = new UnitInfoVo
                {
                    unit_id = (int)datareader["unit_id"],
                    unit_cd = datareader["unit_cd"].ToString(),
                    unit_name = datareader["unit_name"].ToString()
                };
                voList.add(outVo);
            }
            datareader.Close();
            return voList;
        }
    }
}
