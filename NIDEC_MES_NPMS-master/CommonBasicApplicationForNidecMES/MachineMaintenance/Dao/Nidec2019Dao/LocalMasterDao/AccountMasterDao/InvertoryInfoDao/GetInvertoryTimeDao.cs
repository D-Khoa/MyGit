using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetInvertoryTimeDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            InvertoryTimeVo inVo = (InvertoryTimeVo)vo;
            ValueObjectList<InvertoryTimeVo> voList = new ValueObjectList<InvertoryTimeVo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select invertory_time_id, invertory_time_cd, invertory_time_name from m_invertory_time where 1=1 ");
            if (!string.IsNullOrEmpty(inVo.invertory_time_cd))
                sql.Append("and invertory_time_cd='").Append(inVo.invertory_time_cd).Append("' ");
            if (!string.IsNullOrEmpty(inVo.invertory_time_name))
                sql.Append("and invertory_time_name='").Append(inVo.invertory_time_name).Append("' ");
            sql.Append("order by invertory_time_id");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                InvertoryTimeVo outVo = new InvertoryTimeVo
                {
                    invertory_time_id = (int)datareader["invertory_time_id"],
                    invertory_time_cd = datareader["invertory_time_cd"].ToString(),
                    invertory_time_name = datareader["invertory_time_name"].ToString()
                };
                voList.add(outVo);
            }
            datareader.Close();
            return voList;
        }
    }
}
