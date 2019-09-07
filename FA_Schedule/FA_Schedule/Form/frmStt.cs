using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_Schedule
{
    public partial class frmStt : Form
    {
        sqlfirst sql;
        DataTable dt;
        Storage sto;

        public frmStt()
        {
            InitializeComponent();
            sto = Storage.getStorage();
            string table = sto.stt_tb;
            sql = new sqlfirst();
            dt = new DataTable();
            string cmd = "select * from " + table;
            sql.datatable(cmd, ref dt);
            dgvStt.DataSource = dt;
            this.Height = dgvStt.Rows.Count * 30;
            this.Width = dgvStt.Columns.Count * 150;
        }
    }
}
