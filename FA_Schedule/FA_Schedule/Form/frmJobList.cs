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
    public partial class frmJobList : Form
    {
        sqlfirst sql = new sqlfirst();

        public frmJobList()
        {
            InitializeComponent();
            sql.server = "localhost";
            sql.database = "diepdb";
        }
    }
}
