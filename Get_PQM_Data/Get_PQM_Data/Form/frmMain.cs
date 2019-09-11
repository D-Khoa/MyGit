using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Get_PQM_Data
{
    public partial class frmMain : Form
    {
        TfSQL sql;
        
        public static string sernodb = "laa10_003201908";
        public static string inspectdb = sernodb + "data";
        DataTable dt;
        DataTable ds;
        DateTime datea;
        string datef;
        string datet;
        string savepath;
        string openpath;
        string temp;
        string line;
        int c;
        bool tabcomp = false;
        List<string> inslist = new List<string>();
        List<string> serlist = new List<string>();

        public frmMain()
        {
            InitializeComponent();
            Storage sto = Storage.getStorage();
            sto.name = "pqmdb";
            ds = new DataTable();
            temp = "";
            line = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            sql = new TfSQL();
            sql.getComboBoxData("select distinct model from procinsplink", ref cmbModel);
        }

        private void cmbModel_TextChanged(object sender, EventArgs e)
        {
            trInspect.Nodes.Clear();
            string model = cmbModel.Text;
            datea = dtDatef.Value;
            sernodb = model + datea.Year.ToString("0000") + datea.Month.ToString("00");
            inspectdb = sernodb + "data";
            GetTreeview(model);
        }

        void GetTreeview(string model)
        {
            if (model != "")
            {
                TreeNode root = new TreeNode(model);
                trInspect.Nodes.Add(root);
                dt = new DataTable();
                sql.sqlDataAdapterFillDatatable("select distinct inspect from procinsplink"
                                               + " where model = '" + model + "' order by inspect asc", ref dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    root.Nodes.Add(dt.Rows[i]["inspect"].ToString());
                }
            }
        }

        private void trInspect_AfterCheck(object sender, TreeViewEventArgs e)
        {
            inslist.Clear();
            setchecknode(e.Node, e.Node.Checked);
            temp = sender.ToString();
        }

        private void setchecknode(TreeNode node, bool check)
        {
            foreach (TreeNode child in node.Nodes)
            {
                if (child.Checked != check) child.Checked = check;
                if (child.Nodes.Count > 0) setchecknode(child, check);
            }
        }

        private void selectnode(TreeNodeCollection root)
        {
            foreach (TreeNode child in root)
            {
                if (child.Checked == true)
                    inslist.Add(child.Text);
                selectnode(child.Nodes);
            }
            if (temp.Contains(cmbModel.Text)) inslist.RemoveAt(0);
            temp = "";
        }

        //LOAD SERNO FROM FILE CSV
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

        //CREATE STRING TO FIND DATA
        private string inspects()
        {
            try
            {
                string sum = "'" + inslist[0] + "'";
                foreach (string str in inslist)
                {
                    sum += ",'" + str + "'";
                }
                return sum;
            }
            catch (Exception) { return "''"; }
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

        public void gettable()
        {
            tabcomp = false;
            string serno = multxt();
            string inspect = inspects();
            DataTable dts = new DataTable();
            DataTable dti = new DataTable();
            string cmd;
            string cmd2;
            if (serno != "")
            {
                cmd = "select serno, lot, model, site, factory, line, process, inspectdate from " + sernodb + " where serno in(" + serno + ") order by inspectdate asc ";
                cmd2 = "select serno, inspectdate, inspect, inspectdata from " + inspectdb + " where serno in(" + serno + ") and inspect in(" + inspect + ") order by inspect asc, inspectdate asc";
            }
            else if (serno == "" && datef != "" && datet != "")
            {
                cmd = "select serno, lot, model, site, factory, line, process, inspectdate from " + sernodb + " where inspectdate > '" + datef + "' and inspectdate < '" + datet + "' order by inspectdate asc";
                cmd2 = "select serno, inspectdate, inspect, inspectdata from " + inspectdb + " where inspect in(" + inspect + ") and inspectdate > '" + datef + "' and inspectdate < '" + datet + "' order by inspect asc, inspectdate asc";
            }
            else
            {
                cmd = "select serno, lot, model, site, factory, line, process, inspectdate from " + sernodb + "order by inspectdate asc";
                cmd2 = "select serno, inspectdate, inspect, inspectdata from " + inspectdb + " where inspect in(" + inspect + ") order by inspect asc, inspectdate asc";
            }
            sql.sqlDataAdapterFillDatatable(cmd, ref dts);
            sql.sqlDataAdapterFillDatatable(cmd2, ref dti);
            SQLLinQ lin = new SQLLinQ();
            ds = lin.Pivot(dti, dti.Columns["inspect"], dti.Columns["inspectdata"]);
            DataTable dsum = new DataTable();
            dsum = lin.Joined(dts, ds);
            ds.Clear();
            ds = dsum;
            tabcomp = true;
        }


        //FIND DATA
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                c = 0;
                ds.Clear();
                dgvdt.Refresh();
                datef = dtDatef.Text + " " + cmbHoursf.Text + ":" + cmbMinf.Text + ":00";
                datet = dtDatet.Text + " " + cmbHourst.Text + ":" + cmbMint.Text + ":00";
                selectnode(trInspect.Nodes);
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
                dgvdt.DataSource = ds;
                tsProcessing.Text = dgvdt.Rows.Count.ToString() + " Rows";
                timer1.Enabled = false;
            }
        }


        //CREATE CSV FILE
        private void btnCSV_Click(object sender, EventArgs e)
        {
            try
            {
                c = 0;
                ds.Clear();
                datef = dtDatef.Text + " " + cmbHoursf.Text + ":" + cmbMinf.Text + ":00";
                datet = dtDatet.Text + " " + cmbHourst.Text + ":" + cmbMint.Text + ":00";
                selectnode(trInspect.Nodes);
                timer2.Enabled = true;
                File.Create("data.csv");
                sfSaveCSV = new SaveFileDialog();
                sfSaveCSV.RestoreDirectory = true;
                sfSaveCSV.Title = "Save file...";
                sfSaveCSV.Filter = "csv file(*.csv)|*.csv|text file(*.txt)|*.txt|All file(*.*)|*.*";
                //if (sfSaveCSV.ShowDialog() == DialogResult.OK)
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
                ds.ToCSV(@"D:\data.csv");
                //System.Diagnostics.Process.Start(@"D:\data.csv");
                tsProcessing.Text = ds.Rows.Count + " Rows";
                timer2.Enabled = false;
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < txtBarcode.Lines.Length; i++)
                serlist.Add(txtBarcode.Lines[i]);
            lbSerrows.Text = txtBarcode.Lines.Length.ToString() + " rows";
        }
    }
}
