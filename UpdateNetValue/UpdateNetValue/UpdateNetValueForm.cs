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
        DateTime dateStart, dateEnd;
        Stopwatch timer = new Stopwatch();
        double acqCost, monthly, current, accum, net;

        public UpdateNetValueForm()
        {
            InitializeComponent();
            lbMonth.Text = DateTime.Now.ToString("yyyy-MM");
            SQL = new TfSQL();
            dt2 = new DataTable();
            dt2.Columns.Add("account_main_id");
            dt2.Columns.Add("warehouse_main_id");
            dt2.Columns.Add("depreciation_start");
            dt2.Columns.Add("depreciation_end");
            dt2.Columns.Add("monthly");
            dt2.Columns.Add("current");
            dt2.Columns.Add("accum");
            dt2.Columns.Add("net");
        }

        public void GetTable()
        {
            dt = new DataTable();
            cmd = new StringBuilder();
            cmd.Clear();
            cmd.Append("select a.asset_id, b.account_main_id, c.warehouse_main_id, ");
            cmd.Append("b.depreciation_start, b.depreciation_end, ");
            cmd.Append("a.acquistion_cost, b.current_depreciation, b.monthly_depreciation, ");
            cmd.Append("b.accum_depreciation_now, b.net_value ");
            cmd.Append("from m_asset a ");
            cmd.Append("left join t_account_main b on a.asset_id = b.asset_id");
            cmd.Append("left join t_warehouse_main c on a.asset_id = c.asset_id");
            SQL.sqlDataAdapterFillDatatable(cmd.ToString(), ref dt);
        }

        public void UpdateDepreciation(string id, string tbl)
        {
            cmd = new StringBuilder();
            cmd.Clear();
            cmd.Append("update ").Append(tbl).Append(" ");
            cmd.Append("set current_depreciation = '").Append(current).Append("', ");
            cmd.Append("accum_depreciation_now = '").Append(accum).Append("', ");
            cmd.Append("net_value = '").Append(net).Append("' ");
            if (tbl == "t_account_main")
                cmd.Append("where account_main_id = '").Append(id).Append("' ");
            if (tbl == "t_warehouse_main")
                cmd.Append("where warehouse_main_id = '").Append(id).Append("' ");
            cmd.Append("and depreciation_start = '").Append(dateStart).Append("' ");
            cmd.Append("and depreciation_end = '").Append(dateEnd).Append("' ");
        }

        public double MonthDiff(DateTime startDate, DateTime endDate)
        {
            //TimeSpan t = endDate - startDate;
            //double m = (t.TotalDays / 365) * 12;
            //return Math.Abs(m);
            double m = Math.Abs(12 * (endDate.Year - startDate.Year) + endDate.Month - startDate.Month);
            double d = Math.Abs(endDate.Day - startDate.Day);
            if (d > 15)
                return m + 1;
            else
                return m;
        }

        public void CalcDepreciation()
        {
            DateTime now = DateTime.Now;
            double totalMonth = MonthDiff(dateStart, dateEnd);
            double currentMonth = MonthDiff(dateStart, now);
            accum = (monthly * currentMonth);
            current = (accum - monthly);
            net = (acqCost - accum);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            timer.Start();
            GetTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["depreciation_start"].ToString() != "")
                {
                    acqCost = (double)dt.Rows[i]["acquistion_cost"];
                    monthly = (double)dt.Rows[i]["monthly_depreciation"];
                    dateStart = Convert.ToDateTime(dt.Rows[i]["depreciation_start"]);
                    dateEnd = Convert.ToDateTime(dt.Rows[i]["depreciation_end"]);
                    CalcDepreciation();
                    dt2.Rows.Add(dt.Rows[i]["account_main_id"], dt.Rows[i]["warehouse_main_id"],
                        dateStart, dateEnd, Math.Round(monthly, 2), Math.Round(current, 2),
                        Math.Round(accum, 2), Math.Round(net, 2));
                }
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                dateStart = Convert.ToDateTime(dt2.Rows[i]["depreciation_start"]);
                dateEnd = Convert.ToDateTime(dt2.Rows[i]["depreciation_end"]);
                current = (double)dt2.Rows[i]["current"];
                accum = (double)dt2.Rows[i]["accum"];
                net = (double)dt2.Rows[i]["net"];
                UpdateDepreciation(dt2.Rows[i]["account_main_id"].ToString(), "t_account_main");
                UpdateDepreciation(dt2.Rows[i]["warehouse_main_id"].ToString(), "t_warehouse_main");
            }
            dgvDataDt.DataSource = dt;
            dgvData.DataSource = dt2;
            timer.Stop();
            tsRows.Text = dt.Rows.Count.ToString();
            tsStatus.Text = timer.Elapsed.ToString();
        }

        public void CalcSQL()
        {
            string sql;
            sql = "select date_part('month',(age(now(), depreciation_start))) as month, month*monthly_depreciation as accum, acquistion_cost - accum as net";
        }
    }
}
