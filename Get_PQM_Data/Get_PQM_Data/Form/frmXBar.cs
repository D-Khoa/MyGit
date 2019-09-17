using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_PQM_Data
{
    public partial class frmXBar : Form
    {
        //----------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------VARIABLES FIELD-----------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        TfSQL sql;
        DataTable dt;
        List<string> sernodb;
        string sernolist;
        string inspect;
        string lot;
        string judge;
        string dfr;
        string dto;
        int c;
        bool viewcomp = false;

        //----------------------------------------------------------------------------------------------------------------//
        //----------------------------------------------LOAD AND CLOSE FORM-----------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        public frmXBar()
        {
            InitializeComponent();
            //Set database name for SQL connect
            Storage sto = Storage.getStorage();
            sto.name = "pqmdb";
            dt = new DataTable();
            sernodb = new List<string>();
        }

        private void frmXBar_Load(object sender, EventArgs e)
        {
            sql = new TfSQL();
            sql.getComboBoxData("select distinct model from procinsplink order by model asc", ref cmbModel);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //----------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------GET DATA TO COMBOBOX IN OPTION-----------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            grOption.Enabled = true;
            sql.getComboBoxData("select distinct site from processtbl where model ='" + cmbModel.Text 
                              + "' order by site asc", ref cmbSite);
            sql.getComboBoxData("select distinct factory from processtbl where model ='" + cmbModel.Text 
                              + "' order by factory asc", ref cmbFac);
            sql.getComboBoxData("select distinct line from processtbl where model ='" + cmbModel.Text
                               + "' order by line asc", ref cmbLine);
            sql.getComboBoxData("select distinct process from processtbl where model ='" + cmbModel.Text
                               + "' order by process asc", ref cmbProc);
        }

        private void GetInspectItem()
        {
            string cmd = "select distinct inspect from procinsplink where model ='" + cmbModel.Text + "'";
            if (cmbSite.Focused)
                cmd += " and site ='" + cmbSite.Text + "'";
            if (cmbFac.Focused)
                cmd += " and factory ='" + cmbFac.Text + "'";
            if (cmbLine.Focused)
                cmd += " and line ='" + cmbLine.Text + "'";
            if (cmbProc.Focused)
                cmd += " and process ='" + cmbProc.Text + "'";
            cmd += " order by inspect asc";
            sql.getComboBoxData(cmd, ref cmbInsp);
        }

        private void cmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInspectItem();
        }

        private void cmbFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInspectItem();
        }

        private void cmbLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInspectItem();
        }

        private void cmbProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInspectItem();
        }
        //----------------------------------------------------------------------------------------------------------------//
        //-----------------------------LOAD SERIAL NO FROM CSV FILE OR FROM SERIAL NO TEXT BOX----------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void btnBrower_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenCSV = new OpenFileDialog();
            OpenCSV.Title = "Load Serial from CSV file";
            OpenCSV.Filter = "CSV file (*.csv)|*.csv|All file (*.*)|*.*";
            if (OpenCSV.ShowDialog() == DialogResult.OK)
            {
                txtSerno.Text = "";
                txtURL.Text = OpenCSV.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtURL.Text != "")
            {
                int numline = 0;
                sernolist = "";
                txtURL.Text.ReadCSVtoString(ref sernolist, ref numline);
                lbNumline.Text = numline.ToString() + " lines";
            }
        }

        private void GetTxtSerno()
        {
            int numline = 0;
            sernolist = "";
            foreach (string line in txtSerno.Lines)
            {
                sernolist = "'" + line + "',";
                numline++;
            }
            lbNumline.Text = numline.ToString() + " lines";
        }
        //----------------------------------------------------------------------------------------------------------------//
        //-------------------------------------------GET DATA TO TABLE----------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------------//
        private void GetTableName()
        {
            string tblsernoname = "";
            for(int i = dtDatef.Value.Month; i <= dtDatet.Value.Month; i++)
            {
                tblsernoname = cmbModel.Text + dtDatef.Value.Year.ToString("0000") + i.ToString("00");
                sernodb.Add(tblsernoname);
            }
        }

        private void GetDatatable(string tb1, ref DataTable table, string dfrom, string dto)
        {
            string tb2 = tb1 + "data";
            string cmd = "select a.*,b.inspectdata from " + tb1 + " a left join " + tb2 
                       + " b on a.serno = b.serno and a.inspectdate = b.inspectdate where b.inspect ='" + inspect + "'";
            if (sernolist != "")
                cmd += " and a.serno in(" + sernolist + ")";
            else
                cmd += " and a.inspectdate > '" + dfrom + "' and a.inspectdate < '" + dto + "'";
            if (lot != "")
                cmd += " and a.lot ='" + lot + "'";
            if (judge == "OK")
                cmd += " and a.tjudge ='0'";
            else if (judge == "NG")
                cmd += " and a.tjudge ='1'";
            cmd += " order by a.inspectdate asc";
            sql.sqlDataAdapterFillDatatable(cmd, ref table);
        }

        private void GetTable()
        {
            DataTable temp = new DataTable();
            dt = new DataTable();
            if ((dtDatet.Value.Month - dtDatef.Value.Month) == 0)
            {
                GetDatatable(sernodb[0], ref dt, dfr, dto);
            }
            else
            {
                foreach (string name in sernodb)
                {
                    GetDatatable(name, ref temp, dfr, dto);
                    dt.Merge(temp);
                }
            }
            dt.Columns["inspectdata"].ColumnName = inspect;
            dt.Columns.Remove("tstatus");
            dt.Columns.Remove("remark");
            viewcomp = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GetTableName();
            dfr = dtDatef.Text + " " + cmbHoursf.Text + ":" + cmbMinf.Text + ":00";
            dto = dtDatet.Text + " " + cmbHourst.Text + ":" + cmbMint.Text + ":00";
            GetTxtSerno();
            inspect = cmbInsp.Text;
            lot = txtLot.Text;
            judge = cmbJudge.Text;
            c = 0;
            timer1.Enabled = true;
            Thread viewing = new Thread(GetTable);
            viewing.Start();
            viewing.IsBackground = true;
            tsProcessing.Text = "Processing...";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            tsTime.Text = (c / 100).ToString() + "," + ((c % 100) / 10).ToString() + " s";
            if (viewcomp)
            {
                viewcomp = false;
                Storage sto = Storage.getStorage();
                sto.table = dt;
                tsProcessing.Text = dt.Rows.Count.ToString() + " rows";
                frmViewer viewer = new frmViewer();
                viewer.ShowDialog();
                timer1.Enabled = false;
            }
        }
    }
}