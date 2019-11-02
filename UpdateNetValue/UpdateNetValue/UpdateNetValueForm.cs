using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateNetValue
{
    public partial class UpdateNetValueForm : Form
    {
        TfSQL SQL;
        DataTable dt, dt2;
        StringBuilder cmd;
        double monthly, current, accum, net;

        public UpdateNetValueForm()
        {
            InitializeComponent();
            SQL = new TfSQL();
            lbMonth.Text = DateTime.Now.ToString("yyyy-MM");
        }

        public void GetTable()
        {
            dt = new DataTable();
            cmd = new StringBuilder();
            cmd.Clear();
            cmd.Append("select b.account_main_id, a.asset_id, b.depreciation_start, b.depreciation_end, ");
            cmd.Append("a.acquistion_cost, b.current_depreciation, b.monthly_depreciation, ");
            cmd.Append("b.accum_depreciation_now, b.net_value ");
            cmd.Append("from m_asset a ");
            cmd.Append("left join t_account_main b on a.asset_id = b.asset_id");
            SQL.sqlDataAdapterFillDatatable(cmd.ToString(), ref dt);
        }

        public void UpdateDepreciation(int i, string tbl)
        {
            cmd = new StringBuilder();
            cmd.Clear();
            cmd.Append("update ").Append(tbl).Append(" ");
            cmd.Append("set current_depreciation = '").Append(current).Append("', ");
            cmd.Append("accum_depreciation_now = '").Append(accum).Append("', ");
            cmd.Append("net_value = '").Append(net).Append("' ");
            cmd.Append("where asset_id = '").Append(dt2.Rows[i]["asset_id"]).Append("'");
        }

        public double MonthDiff(DateTime startDate, DateTime endDate)
        {
            //TimeSpan t = endDate - startDate;
            //double m = (t.TotalDays / 365) * 12;
            double m = Math.Abs(12 * (endDate.Year - startDate.Year) + endDate.Month - startDate.Month);
            double d = Math.Abs(endDate.Day - startDate.Day);
            if (d > 15)
                return m + 1;
            else
                return m;
            //return Math.Abs(m);
        }

        public void CalcDepreciation(double acqCost, DateTime startDate, DateTime endDate)
        {
            DateTime now = DateTime.Now;
            double totalMonth = MonthDiff(startDate, endDate);
            double currentMonth = MonthDiff(startDate, now);
            //monthly = acqCost / totalMonth;
            accum = (monthly * currentMonth);
            current = (accum - monthly);
            net = (acqCost - accum);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            dt2 = new DataTable();
            GetTable();
            dt2.Columns.Add("asset_id");
            dt2.Columns.Add("monthly");
            dt2.Columns.Add("current");
            dt2.Columns.Add("accum");
            dt2.Columns.Add("net");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["depreciation_start"].ToString() != "")
                {
                    monthly = (double)dt.Rows[i]["monthly_depreciation"];
                    CalcDepreciation((double)dt.Rows[i]["acquistion_cost"], Convert.ToDateTime(dt.Rows[i]["depreciation_start"]), Convert.ToDateTime(dt.Rows[i]["depreciation_end"]));
                    dt2.Rows.Add(dt.Rows[i]["asset_id"], Math.Round(monthly, 2), Math.Round(current, 2), Math.Round(accum, 2), Math.Round(net, 2));
                    UpdateDepreciation(i, "t_account_main");
                }
            }
            dgvDataDt.DataSource = dt;
            dgvData.DataSource = dt2;
            timer.Stop();
            tsRows.Text = dt.Rows.Count.ToString();
            tsStatus.Text = timer.Elapsed.ToString();
        }
    }
}
