using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MainForm : Form
    {
        DataTable dt = new DataTable();
        List<string> ProcessName;

        public MainForm()
        {
            InitializeComponent();
            {
                dt.Columns.Add("Application");
                dt.Columns.Add("Link");
                dt.Columns.Add("Username");
                dt.Columns.Add("Password");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessName = (from a in System.Diagnostics.Process.GetProcesses()
                               where a.MainWindowTitle.Length > 0
                               select a.MainWindowTitle).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmbProcess.DataSource = ProcessName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItemForm add = new AddItemForm();
            if (add.ShowDialog() == DialogResult.OK)
            {
                DataRow dr = dt.NewRow();
                dr[0] = cmbProcess.Text;
                dr[1] = add.url;
                dr[2] = add.name;
                dr[3] = add.pass;
                dt.Rows.Add(dr);
                dgvData.DataSource = dt;
                dgvData.Refresh();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = (DataTable)dgvData.DataSource;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void cmbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable view = new DataTable();
            view = dt.DefaultView.ToTable(true, "Application");
        }
    }
}
