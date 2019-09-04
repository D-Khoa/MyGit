using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_Schedule
{
    public partial class UserDetail : UserControl
    {
        public UserDetail()
        {
            InitializeComponent();
            Storage sto = Storage.getStorage();
            lbUsername.Text = sto.name;
            lbID.Text = sto.id;
        }
    }
}
