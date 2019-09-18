using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_PQM_Data
{
    public partial class frmViewer : Form
    {
        public frmViewer()
        {
            InitializeComponent();
            Storage sto = Storage.getStorage();
            dgvData.DataSource = sto.table;
            tsProcessing.Text = dgvData.Rows.Count.ToString() + " rows";
        }
    }
}
