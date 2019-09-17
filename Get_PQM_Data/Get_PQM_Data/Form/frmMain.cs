using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Get_PQM_Data
{
    public partial class frmMain : Form
    {
        //----------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------VARIABLES FIELD-----------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        TfSQL sql;
        DataTable ds;

        List<string> inslist = new List<string>();
        List<string> serlist = new List<string>();
        List<string> sernodb;
        string savepath;
        string openpath;
        string datef;
        string datet;
        string temp;
        string line;
        bool tabcomp = false;
        int c;
        //----------------------------------------------------------------------------------------------------------------//
        //----------------------------------------------LOAD FORM COMBOBOX MODEL------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        public frmMain()
        {
            InitializeComponent();
            //Set database name for SQL connect
            Storage sto = Storage.getStorage();
            sto.name = "pqmdb";

            ds = new DataTable();
            sernodb = new List<string>();
            temp = "";
            line = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Get model name into combobox
            sql = new TfSQL();
            sql.getComboBoxData("select distinct model from procinsplink order by model asc", ref cmbModel);
        }
        //----------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------GET TREEVIEW-----------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void cmbModel_TextChanged(object sender, EventArgs e)
        {
            string model = cmbModel.Text;
            //Renew treeview follow model
            trInspect.Nodes.Clear();
            trInspect.GetRoot("", GetListRoot(model));
            foreach(TreeNode root in trInspect.Nodes)
            {
                root.GetNodes(GetListNodes(root.Text));
            }
        }

        private List<string> GetListRoot(string model)
        {
            List<string> rootlist = new List<string>();
            sql.getListString("select distinct process from processtbl where model ='" + model
                            + "' order by process asc", ref rootlist);
            return rootlist;
        }

        private List<string> GetListNodes(string Root)
        {
            List<string> nodelist = new List<string>();
            sql.getListString("select distinct inspect from procinsplink where process ='" + Root
                            + "' order by inspect asc", ref nodelist);
            return nodelist;
        }
        //----------------------------------------------------------------------------------------------------------------//
        //----------------------------------------GET INSPECT LIST--------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void trInspect_AfterCheck(object sender, TreeViewEventArgs e)
        {
            inslist.Clear();
            e.Node.CheckedNode(e.Node.Checked);
        }

        private string inspects(ref List<string> list)
        {
            try
            {
                string sum = "";
                foreach (string line in GetListRoot(temp))
                {
                    if (list[0] == line)
                        list.RemoveAt(0);
                }
                sum = "'" + list[0] + "'";
                list.RemoveAt(0);
                foreach (string str in list)
                {
                    sum += ",'" + str + "'";
                }
                return sum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "''";
            }
        }
        //----------------------------------------------------------------------------------------------------------------//
        //----------------------------------------GET SERNO LIST----------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < txtBarcode.Lines.Length; i++)
                serlist.Add(txtBarcode.Lines[i]);
            lbSerrows.Text = txtBarcode.Lines.Length.ToString() + " rows";
        }

        private string multxt()
        {
            try
            {
                if (serlist.Count > 0)
                {
                    line = "";
                    line = "'" + serlist[0] + "'";
                    foreach (string r in serlist)
                    {
                        line += ",'" + r + "'";
                    }
                }
                return line;
            }
            catch (Exception) { return "''"; }
        }

        //----------------------------------------------------------------------------------------------------------------//
        //------------------------------------------LOAD SERNO FROM CSV---------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void btnBrower_Click(object sender, EventArgs e)
        {
            ofCSV = new OpenFileDialog();
            ofCSV.Title = "Load serno file...";
            ofCSV.Filter = "csv file(*.csv)|*.csv|text file(*.txt)|*.txt|All file(*.*)|*.*";
            if (ofCSV.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = ofCSV.FileName;
                openpath = txtURL.Text;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                line = "";
                openpath.ReadCSVtoString(ref line, ref num);
                line = line.Substring(0, line.Length - 1);
                lbSerrows.Text = num + " rows";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //----------------------------------------------------------------------------------------------------------------//
        //------------------------------------------GET TABLE FROM DATABASE-----------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void getTableName()
        {
            string name ="";
            for (int i = dtDatef.Value.Month; i <= dtDatet.Value.Month; i++)
            {
                name = cmbModel.Text + dtDatef.Value.Year.ToString("0000") + i.ToString("00");
                sernodb.Add(name);
            }
        }

        private void getdatatable(ref DataTable dt1, ref DataTable dt2, string tb1, string dfr, string dto)
        {
            string serno = multxt();
            string inspect = inspects(ref inslist);
            string tb2 = tb1 + "data";
            string cmd = "select serno, lot, model, site, factory, line, process, inspectdate from "
                       + tb1 + " where 1=1 ";
            string cmd2 = "select serno, inspectdate, inspect, inspectdata from " + tb2 + " where 1=1 ";
            if (serno != "")
            {
                cmd += "and serno in(" + serno + ") order by inspectdate asc ";
                cmd2 += "and serno in(" + serno + ") and inspect in(" + inspect + ") order by inspect asc, inspectdate asc";
            }
            else
            {
                cmd += "and inspectdate > '" + dfr + "' and inspectdate < '" + dto
                    + "' order by inspectdate asc";
                cmd2 += "and inspect in(" + inspect + ") and inspectdate > '" + dfr + "' and inspectdate < '" + dto + "' order by inspect asc, inspectdate asc";
            }
            sql.sqlDataAdapterFillDatatable(cmd, ref dt1);
            sql.sqlDataAdapterFillDatatable(cmd2, ref dt2);
        }

        public void gettable()
        {
            DataTable dts = new DataTable();
            DataTable dti = new DataTable();
            if (dtDatet.Value.Month - dtDatef.Value.Month == 0)
                getdatatable(ref dts, ref dti, sernodb[0], datef, datet);
            else
            {
                DataTable temp1 = new DataTable();
                DataTable temp2 = new DataTable();
                foreach(string name in sernodb)
                {
                    getdatatable(ref temp1, ref temp2, name, datef, datet);
                    dts.Merge(temp1);
                    dti.Merge(temp2);
                }
            }
            SQLLinQ lin = new SQLLinQ();
            ds = lin.Pivot(dti, dti.Columns["inspect"], dti.Columns["inspectdata"]);
            DataTable dsum = new DataTable();
            dsum = lin.Joined(dts, ds);
            ds.Clear();
            ds = dsum;
            tabcomp = true;
        }
        //----------------------------------------------------------------------------------------------------------------//
        //------------------------------------------SEARCH DATA-----------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                c = 0;
                ds.Clear();
                dgvdt.Refresh();
                getTableName();
                datef = dtDatef.Text + " " + cmbHoursf.Text + ":" + cmbMinf.Text + ":00";
                datet = dtDatet.Text + " " + cmbHourst.Text + ":" + cmbMint.Text + ":00";
                trInspect.Nodes.SelectNodes(ref inslist);
                temp = cmbModel.Text;
                timer1.Enabled = true;
                Thread tab = new Thread(gettable);
                tab.Start();
                tab.IsBackground = true;
                tsProcessing.Text = "processing...";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "NoInspect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            tsTime.Text = (c / 100).ToString() + "," + ((c % 100) / 10).ToString() + " s";
            if (tabcomp)
            {
                tabcomp = false;
                dgvdt.DataSource = ds;
                tsProcessing.Text = dgvdt.Rows.Count.ToString() + " Rows";
                timer1.Enabled = false;
            }
        }
        //----------------------------------------------------------------------------------------------------------------//
        //------------------------------------------EXPORT TO CSV---------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void btnCSV_Click(object sender, EventArgs e)
        {
            try
            {
                c = 0;
                ds.Clear();
                getTableName();
                datef = dtDatef.Text + " " + cmbHoursf.Text + ":" + cmbMinf.Text + ":00";
                datet = dtDatet.Text + " " + cmbHourst.Text + ":" + cmbMint.Text + ":00";
                trInspect.Nodes.SelectNodes(ref inslist);
                timer2.Enabled = true;
                //File.Create("data.csv");
                sfSaveCSV = new SaveFileDialog();
                sfSaveCSV.RestoreDirectory = true;
                sfSaveCSV.Title = "Save file...";
                sfSaveCSV.Filter = "csv file(*.csv)|*.csv|text file(*.txt)|*.txt|All file(*.*)|*.*";
                if (sfSaveCSV.ShowDialog() == DialogResult.OK)
                {
                    savepath = sfSaveCSV.FileName;

                    Thread tab = new Thread(gettable);
                    tab.Start();
                    tab.IsBackground = true;
                    tsProcessing.Text = "processing...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "NoInspect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            c++;
            tsTime.Text = (c / 100).ToString() + "," + ((c % 100) / 10).ToString() + " s";
            if (tabcomp)
            {
                tabcomp = false;
                //ds.ToCSV(@"D:\data.csv");
                ds.ToCSV(savepath);
                System.Diagnostics.Process.Start(savepath);
                tsProcessing.Text = ds.Rows.Count + " Rows";
                timer2.Enabled = false;
            }
        }
    }
}
