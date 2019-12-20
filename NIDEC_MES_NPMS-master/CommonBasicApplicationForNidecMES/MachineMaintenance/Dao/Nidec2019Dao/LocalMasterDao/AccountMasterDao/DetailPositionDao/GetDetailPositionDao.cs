using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetDetailPositionDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            DetailPositionVo inVo = (DetailPositionVo)vo;
            ValueObjectList<DetailPositionVo> voList = new ValueObjectList<DetailPositionVo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select distinct detail_postion_id, detail_postion_cd, detail_postion_name from m_detail_postion where 1=1 ");
            if (!string.IsNullOrEmpty(inVo.detail_postion_cd))
                sql.Append("and detail_postion_cd='").Append(inVo.detail_postion_cd).Append("' ");
            if (!string.IsNullOrEmpty(inVo.detail_postion_name))
                sql.Append("and detail_postion_name='").Append(inVo.detail_postion_name).Append("' ");
            sql.Append("order by detail_postion_id");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                DetailPositionVo outVo = new DetailPositionVo
                {
                    detail_postion_id = (int)datareader["detail_postion_id"],
                    detail_postion_cd = datareader["detail_postion_cd"].ToString(),
                    detail_postion_name = datareader["detail_postion_name"].ToString()
                };
                voList.add(outVo);
            }
            datareader.Close();
            return voList;
        }
    }
}
