using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldMonitor.Model
{
    public static class GetData
    {
        static TfSQL SQL = new TfSQL();
        //static SSQL SQL = new SSQL();
        static StringBuilder command = new StringBuilder();

        public static void GetModelToCombobox(this System.Windows.Forms.ComboBox cmb)
        {
            command.Append("Select distinct model from modeltbl order by model");
            SQL.getComboBoxData(command.ToString(), ref cmb);
            command.Clear();
        }

        public static void GetProcessToList(ref List<string> list, string Model)
        {
            list = new List<string>();
            command.Append("select distinct process from processtbl where model = '" + Model + "' order by process");
            SQL.getListString(command.ToString(), ref list);
            command.Clear();
        }

        public static double GetInput(string Process, string Table, DateTime DateFrom, DateTime DateTo)
        {
            command.Append("select count(*) as input from ").Append(Table);
            command.Append(" where process = '").Append(Process).Append("'");
            command.Append(" and inspectdate >= '").Append(DateFrom.ToString("yyyy-MM-dd HH:mm:ss")).Append("'");
            command.Append(" and inspectdate <= '").Append(DateTo.ToString("yyyy-MM-dd HH:mm:ss")).Append("'");
            double d = SQL.sqlExecuteScalarDouble(command.ToString());
            command.Clear();
            return d;
        }

        public static double GetOutput(string Process, string Table, DateTime DateFrom, DateTime DateTo)
        {
            command.Append("select count(case when tjudge = '0' then 1 end) as output from ").Append(Table);
            command.Append(" where process = '").Append(Process).Append("'");
            command.Append(" and inspectdate >= '").Append(DateFrom.ToString("yyyy-MM-dd HH:mm:ss")).Append("'");
            command.Append(" and inspectdate <= '").Append(DateTo.ToString("yyyy-MM-dd HH:mm:ss")).Append("'");
            double d = SQL.sqlExecuteScalarDouble(command.ToString());
            command.Clear();
            return d;
        }
    }
}
