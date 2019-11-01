using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        DateTime now;
        DateTime start_depc, end_depc;
        TimeSpan t;
        double acq, monthly, current, accum, net;

        public UpdateNetValueForm()
        {
            InitializeComponent();
            SQL = new TfSQL();
            dt = new DataTable();
            dt2 = new DataTable();
            cmd = new StringBuilder();
        }

        bool button = false;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!button)
            {
                button = true;
                btnUpdate.Text = "Stop";
                now = DateTime.Now;
                //start_depc = new List<DateTime>();
                //end_depc = new List<DateTime>();

                cmd.Append("select a.asset_id, b.depreciation_start, b.depreciation_end, a.acquistion_cost, b.current_depreciation, b.monthly_depreciation, b.accum_depreciation_now, b.net_value ");
                cmd.Append("from m_asset a");
                cmd.Append(" left join t_account_main b on a.asset_id = b.asset_id");
                SQL.sqlDataAdapterFillDatatable(cmd.ToString(), ref dt);
                foreach (DataColumn c in dt.Columns)
                {
                    dt2.Columns.Add(c.ColumnName);
                }
                foreach (DataRow r in dt.Rows)
                {
                    start_depc = (DateTime)r["depreciation_start"];
                    end_depc = (DateTime)r["depreciation_end"];
                    acq = (double)r["acquistion_cost"];
                    //t = end_depc - start_depc;
                    //double diff = t.TotalDays / 30;
                    if (end_depc.Month > start_depc.Month)
                        double m = (double)((end_depc.Year - start_depc.Year) * 12 + (end_depc.Month - start_depc.Month));
                    monthly = acq / (diff);
                    t = now - start_depc;
                    diff = t.TotalDays / 30;
                    current = diff * monthly;
                    accum = current + monthly;
                    net = acq - current;
                    dt2.Rows.Add(r["asset_id"], r["depreciation_start"], r["depreciation_end"], r["acquistion_cost"], current, monthly, accum, net);
                }
                dgvData.DataSource = dt2;
            }
            else
            {
                button = false;
                btnUpdate.Text = "Update";
            }
        }
    }
}
