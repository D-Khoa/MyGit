using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace ShippingNSTVTool
{
    public partial class MainForm : CommonForm
    {
        DataTable dt;
        int counter = 0;
        TfSQL SQL = new TfSQL();
        DateTime toDate = new DateTime();
        DateTime fromDate = new DateTime();
        StringBuilder cmd = new StringBuilder();

        public MainForm()
        {
            InitializeComponent();
            SettingState(false);
            SettingFile(false);
            CreateTable();
        }

        //Create columns for table
        private void CreateTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Barcode");
            dt.Columns.Add("Model");
            dt.Columns.Add("Line");
            dt.Columns.Add("Lot");
            dt.Columns.Add("checkdate");
        }

        //Set state for panel setting
        private void SettingState(bool state)
        {
            btnApply.Visible = state;
            pnlSetting.Enabled = state;
            txtBarcode.Enabled = !state;
        }

        //Setup lbStatus color and text
        private void StatusState(string text, bool state)
        {
            if (state)
            {
                lbStatus.BackColor = Color.Green;
                lbStatus.ForeColor = Color.Black;
            }
            else
            {
                lbStatus.BackColor = Color.Red;
                lbStatus.ForeColor = Color.Black;
            }
            lbStatus.Text = text;
            dgvData.Refresh();
            dgvData.DataSource = dt;
        }

        //Save and load setting file
        private void SettingFile(bool state)
        {
            List<string> setList = new List<string>();
            if (state)
            {
                setList.Add("Model = " + txtModel.Text);
                setList.Add("Line = " + txtLine.Text);
                setList.Add("Lot = " + txtLot.Text);
                setList.Add("Code = " + txtCode.Text);
                if (!File.Exists(@"/setting.txt"))
                    File.Create(@"/setting.txt");
                File.WriteAllLines(@"/setting.txt", setList);
            }
            else
            {
                if (!File.Exists(@"/setting.txt"))
                    File.Create(@"/setting.txt");
                else
                {
                    foreach (string line in File.ReadAllLines(@"/setting.txt"))
                    {
                        setList.Add(line);
                    }
                    if (setList.Count > 0)
                    {
                        txtModel.Text = setList[0].Remove(0, 7);
                        txtLine.Text = setList[1].Remove(0, 6);
                        txtLot.Text = setList[2].Remove(0, 5);
                        txtCode.Text = setList[3].Remove(0, 6);
                    }
                }
            }
        }

        //Check format of barcode
        private bool CheckBarcode()
        {
            if (txtBarcode.Text.Contains(txtCode.Text))
                return true;
            else
                return false;
        }

        //Click Setting button for setup Model, Line, Lot...
        private void btnSetting_Click(object sender, EventArgs e)
        {
            //Set password = nstv1111
            LockForm lockfrm = new LockForm("nstv1111");
            if (lockfrm.ShowDialog() == DialogResult.OK)
            {
                SettingState(true);
            }
        }

        //Click Apply button for Apply setting
        private void btnApply_Click(object sender, EventArgs e)
        {
            SettingState(false);
            SettingFile(true);
            txtBarcode.Focus();
        }

        //Click Export button for Export data to Excel file
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog savef = new SaveFileDialog();
            savef.Filter = @"Excel 2000 - 2003 documents (*.xls)|*.xls|
                             Excel 2007 documents (*.xlsx)|*.xlsx|
                             All file (*.*)|*.*";
            savef.AddExtension = true;
            if (savef.ShowDialog() == DialogResult.OK)
            {
                ExcelClass excel = new ExcelClass(savef.FileName);
                excel.CreateWorkBook();
                excel.AddDatatable(dt);
                excel.SaveAndExit();
            }
            txtBarcode.Focus();
        }

        //Click Confirm button for insert data into database
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CheckBarcode())
            {
                string recDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                dt.Clear();
                cmd.Clear();
                cmd.Append("insert into t_barcode_rec(barcode, model, line, lot, rec_date) ");
                cmd.Append("values('").Append(txtBarcode.Text).Append("','");
                cmd.Append(txtModel.Text).Append("','").Append(txtLine.Text).Append("','");
                cmd.Append(txtLot.Text).Append("','").Append(recDate).Append("')");
                switch (SQL.sqlExecuteNonQueryState(cmd.ToString(), false))
                {
                    case 0:
                        StatusState("Fail", false);
                        break;
                    case 1:
                        DataRow dr = dt.NewRow();
                        dr[0] = txtBarcode.Text;
                        dr[1] = txtModel.Text;
                        dr[2] = txtLine.Text;
                        dr[3] = txtLot.Text;
                        dr[4] = recDate;
                        dt.Rows.Add(dr);
                        StatusState("OK", true);
                        counter++;
                        lbCounter.Text = counter.ToString();
                        break;
                    case 2:
                        StatusState("Dupplicate", false);
                        break;
                    case 3:
                        StatusState("Error", false);
                        break;
                }
            }
            txtBarcode.Clear();
            txtBarcode.Focus();
        }

        //Click Search button for search data from database
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt.Clear();
            cmd.Clear();
            toDate = dtpTo.Value;
            fromDate = dtpFrom.Value;
            cmd.Append("select * from t_barcode_rec where 1=1 ");
            if (txtBarcode.Text != "")
                cmd.Append("and barcode like '").Append(txtBarcode.Text).Append("' ");
            cmd.Append("and rec_date > '").Append(fromDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("' ");
            cmd.Append("and rec_date < '").Append(toDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("'");
            SQL.sqlDataAdapterFillDatatable(cmd.ToString(), ref dt);
            dgvData.Refresh();
            dgvData.DataSource = dt;
            txtBarcode.Focus();
        }
    }
}
