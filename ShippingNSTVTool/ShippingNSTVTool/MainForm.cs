using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShippingNSTVTool
{
    public partial class MainForm : Form
    {
        TfSQL SQL;
        DataTable dt;
        ExcelClass excel;
        StringBuilder cmd;
        DateTime fromDate, toDate;

        public MainForm()
        {
            InitializeComponent();
            SQL = new TfSQL();
            dt = new DataTable();
            dt.Columns.Add("Barcode");
            dt.Columns.Add("Model");
            dt.Columns.Add("Line");
            dt.Columns.Add("Lot");
            dt.Columns.Add("ShipDate");
            toDate = new DateTime();
            fromDate = new DateTime();
            cmd = new StringBuilder();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string shipDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.Clear();
            cmd.Append("insert into t-shipping_nstv(barcode, model, line, lot, shipdate)");
            cmd.Append("values('").Append(txtBarcode.Text).Append("','");
            cmd.Append(cmbModel.Text).Append("','").Append(txtLine.Text).Append("','");
            cmd.Append(txtLot.Text).Append("','").Append(shipDate).Append("'");
            if (SQL.sqlExecuteNonQuery(cmd.ToString(), false))
            {
                pnlStatus.BackColor = Color.Green;
                lbStatus.Text = "OK";
                dt.Clear();
                DataRow dr = dt.NewRow();
                dr[0] = txtBarcode.Text;
                dr[1] = cmbModel.Text;
                dr[2] = txtLine.Text;
                dr[3] = txtLot.Text;
                dr[4] = shipDate;
                dt.Rows.Add(dr);
                dgvData.DataSource = dt;
                dgvData.Refresh();
                txtBarcode.Clear();
            }
            else
            {
                pnlStatus.BackColor = Color.Red;
                lbStatus.Text = "DUPPLICATE";
                dgvData.Dispose();
            }
            txtBarcode.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            toDate = dtpTo.Value;
            fromDate = dtpFrom.Value;
            dt.Clear();
            cmd.Clear();
            cmd.Append("select * from t-shipping_nstv where ");
            cmd.Append("shipdate > '").Append(fromDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("' ");
            cmd.Append("and shipdate < '").Append(toDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("'");
            SQL.sqlDataAdapterFillDatatable(cmd.ToString(), ref dt);
            dgvData.DataSource = dt;
            dgvData.Refresh();
            txtBarcode.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            excel = new ExcelClass(txtURL.Text);
            excel.CreateWorkBook();
            excel.AddDatatable(dt);
            excel.SaveAndExit();
            txtBarcode.Focus();
        }
    }
}
