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
            dt = new DataTable();
            SettingState(false);
            SettingFile(false);
            //CreateTable();
        }

        #region CHECK DATA FORMAT
        //Check format of barcode
        private bool CheckBarcode()
        {
            if (txtBarcode.Text.Contains(txtCode.Text))
                return true;
            else
            {
                throw new Exception("Wrong barcode format!");
            }
        }

        //Check textbox empty
        private bool CheckEmpty()
        {
            if (txtModel.Text != "" && txtLine.Text != "" && txtLot.Text != "" && txtCode.Text != "")
                return true;
            else
            {
                throw new Exception("Information is empty!");
            }
        }
        #endregion

        #region DATATABLE SETTING
        //Create columns for table
        private void CreateTable()
        {
            dt.Columns.Add("Barcode");
            dt.Columns.Add("Model");
            dt.Columns.Add("Line");
            dt.Columns.Add("Lot");
            dt.Columns.Add("checkdate");
        }

        private void GetTable(bool searchFlag)
        {
            dt.Clear();
            cmd.Clear();
            cmd.Append("select * from t_barcode_rec where 1=1 ");
            if (txtBarcode.Text != "")
                cmd.Append("and barcode = '").Append(txtBarcode.Text).Append("' ");
            else
                cmd.Append("and barcode like '").Append(txtCode.Text).Append("%' ");
            if (searchFlag)
            {
                cmd.Append("and rec_date >= '").Append(fromDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("' ");
                cmd.Append("and rec_date <= '").Append(toDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("'");
            }
            SQL.sqlDataAdapterFillDatatable(cmd.ToString(), ref dt);
        }
        #endregion

        #region BUTTON SETTING
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
            savef.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls|All file (*.*)|*.*";
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
            try
            {
                if (CheckBarcode() && CheckEmpty())
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
                            StatusState("Fail", 2);
                            break;
                        case 1:
                            //DataRow dr = dt.NewRow();
                            //dr[0] = txtBarcode.Text;
                            //dr[1] = txtModel.Text;
                            //dr[2] = txtLine.Text;
                            //dr[3] = txtLot.Text;
                            //dr[4] = recDate;
                            //dt.Rows.Add(dr);
                            counter++;
                            GetTable(false);
                            StatusState("OK", 0);
                            lbCounter.Text = counter.ToString();
                            break;
                        case 2:
                            StatusState("Dupplicate", 1);
                            break;
                        case 3:
                            StatusState("Error", 2);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warring");
            }
            txtBarcode.Clear();
            txtBarcode.Focus();
        }

        //Click Search button for search data from database
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //dt.Clear();
            //cmd.Clear();
            toDate = dtpTo.Value;
            fromDate = dtpFrom.Value;
            //cmd.Append("select * from t_barcode_rec where 1=1 ");
            //if (txtBarcode.Text != "")
            //    cmd.Append("and barcode like '").Append(txtBarcode.Text).Append("' ");
            //cmd.Append("and rec_date >= '").Append(fromDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("' ");
            //cmd.Append("and rec_date <= '").Append(toDate.ToString("yyyy-MM-dd HH:mm:ss")).Append("'");
            //SQL.sqlDataAdapterFillDatatable(cmd.ToString(), ref dt);
            GetTable(true);
            StatusState("Finish", 0);
            txtBarcode.Focus();
        }
        #endregion

        #region DISPLAY SETTING
        //Set state for panel setting
        private void SettingState(bool state)
        {
            btnApply.Visible = state;
            pnlSetting.Enabled = state;
            txtBarcode.Enabled = !state;
        }

        //Setup lbStatus color and text (0: OK, 1: Error, 2: Dupplicate)
        private void StatusState(string text, int state)
        {
            switch (state)
            {
                case 0:
                    lbStatus.BackColor = Color.Green;
                    lbStatus.ForeColor = Color.Black;
                    break;
                case 1:
                    dt.Clear();
                    lbStatus.BackColor = Color.Yellow;
                    lbStatus.ForeColor = Color.Black;
                    break;
                case 2:
                    dt.Clear();
                    lbStatus.BackColor = Color.Red;
                    lbStatus.ForeColor = Color.Black;
                    break;
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
                setList.Clear();
                setList.Add("Model = " + txtModel.Text);
                setList.Add("Line = " + txtLine.Text);
                setList.Add("Lot = " + txtLot.Text);
                setList.Add("Code = " + txtCode.Text);
                if (!File.Exists(@"../../setting.txt"))
                    File.Create(@"../../setting.txt");
                File.WriteAllLines(@"../../setting.txt", setList);
            }
            else
            {
                if (!File.Exists(@"../../setting.txt"))
                    File.Create(@"../../setting.txt");
                else
                {
                    setList.Clear();
                    foreach (string line in File.ReadAllLines(@"../../setting.txt"))
                    {
                        setList.Add(line);
                    }
                    if (setList.Count > 0)
                    {
                        txtModel.Text = setList[0].Remove(0, 8);
                        txtLine.Text = setList[1].Remove(0, 7);
                        txtLot.Text = setList[2].Remove(0, 6);
                        txtCode.Text = setList[3].Remove(0, 7);
                    }
                }
            }
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want exit?", "Waring", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
