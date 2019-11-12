using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShippingNSTVTool
{
    public partial class MainForm : CommonForm
    {
        TfSQL SQL;
        DataTable dt;
        ExcelClass excel;
        StringBuilder cmd;
        DateTime fromDate, toDate;
        int counter;

        public MainForm()
        {
            InitializeComponent();
            SQL = new TfSQL();
            getModel();
            counter = 0;
            dt = new DataTable();
            dt.Columns.Add("Barcode");
            dt.Columns.Add("Model");
            dt.Columns.Add("Line");
            dt.Columns.Add("Lot");
            dt.Columns.Add("checkdate");
            toDate = new DateTime();
            fromDate = new DateTime();
            cmd = new StringBuilder();
            btnApply.Visible = false;
            pnlSetting.Enabled = false;
        }

        void getModel()
        {
            string sql = "select distinct model_name from t_model";
            SQL.getComboBoxData(sql, ref cmbModel);
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select distinct model_line from t_model where model_name ='" + cmbModel.Text + "'";
            SQL.getComboBoxData(sql, ref cmbLine);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string checkdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.Clear();
            cmd.Append("insert into t_barcode_rec(barcode, model, line, lot, rec_date) ");
            cmd.Append("values('").Append(txtBarcode.Text).Append("','");
            cmd.Append(cmbModel.Text).Append("','").Append(cmbLine.Text).Append("','");
            cmd.Append(txtLot.Text).Append("','").Append(checkdate).Append("')");
            if (SQL.sqlExecuteNonQuery(cmd.ToString(), false))
            {
                counter++;
                dt.Clear();
                lbStatus.Text = "OK";
                lbStatus.BackColor = Color.Green;
                lbCounter.Text = counter.ToString();
                DataRow dr = dt.NewRow();
                dr[0] = txtBarcode.Text;
                dr[1] = cmbModel.Text;
                dr[2] = cmbLine.Text;
                dr[3] = txtLot.Text;
                dr[4] = checkdate;
                dt.Rows.Add(dr);
                txtBarcode.Clear();
                dgvData.Refresh();
                dgvData.DataSource = dt;
            }
            else
            {
                lbStatus.Text = "DUPPLICATE";
                lbStatus.BackColor = Color.Red;
                txtBarcode.Clear();
                dt.Clear();
                dgvData.Refresh();
                dgvData.DataSource = dt;
            }
            txtBarcode.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt.Clear();
            cmd.Clear();
            txtBarcode.Focus();
            toDate = dtpTo.Value;
            fromDate = dtpFrom.Value;
            cmd.Append("select * from t_barcode_rec where ");
            cmd.Append("checkdate > '").Append(fromDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("' ");
            cmd.Append("and checkdate < '").Append(toDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("'");
            SQL.sqlDataAdapterFillDatatable(cmd.ToString(), ref dt);
            dgvData.Refresh();
            dgvData.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want exit?", "Waring", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            counter = 0;
            txtBarcode.Clear();
            txtBarcode.Focus();
            lbCounter.Text = "0";
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            LockForm lockfrm = new LockForm("nstv1111");
            if (lockfrm.ShowDialog() == DialogResult.OK)
            {
                btnApply.Visible = true;
                pnlSetting.Enabled = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            btnApply.Visible = false;
            pnlSetting.Enabled = false;
            txtBarcode.Focus();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            excel = new ExcelClass(txtURL.Text);
            excel.CreateWorkBook();
            excel.AddDatatable(dt);
            excel.SaveAndExit();
            txtBarcode.Focus();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            SaveFileDialog savef = new SaveFileDialog();
            savef.Filter = "Excel documents (*.xls)|*.xls|Excel 2007 documents (*.xlsc)|*.xlsc|All file (*.*)|*.*";
            savef.AddExtension = true;
            if (savef.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = savef.FileName;
            }
        }
    }
}
