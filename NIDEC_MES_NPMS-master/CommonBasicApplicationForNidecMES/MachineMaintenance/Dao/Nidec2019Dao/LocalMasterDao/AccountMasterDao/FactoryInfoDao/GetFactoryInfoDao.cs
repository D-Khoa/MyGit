using System.Text;
using System.Data;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo.Nidec2019Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao.Nidec2019Dao
{
    public class GetFactoryInfoDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            ValueObjectList<FactoryInfoVo> voList = new ValueObjectList<FactoryInfoVo>();
            StringBuilder sql = new StringBuilder();
            //CREATE SQL ADAPTER AND PARAMETER LIST
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("select distinct factory_cd, factory_name from m_factory order by factory_cd");
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            sql.Clear();
            //EXECUTE READER FROM COMMAND
            IDataReader datareader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            while (datareader.Read())
            {
                FactoryInfoVo outVo = new FactoryInfoVo
                {
                    factory_cd = datareader["factory_cd"].ToString(),
                    factory_name = datareader["factory_name"].ToString()
                };
                voList.add(outVo);
            }
            datareader.Close();
            return voList;
        }
    }
}
