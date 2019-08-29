using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modules
{
    public partial class BaseCellPanel : UserControl
    {
        private string _cell_name;
        private string _cell_price;

        public string Cell_name
        {
            get
            {
                return _cell_name;
            }

            set
            {
                _cell_name = value;
                Invalidate();
            }
        }

        public string Cell_price
        {
            get
            {
                return _cell_price;
            }

            set
            {
                _cell_price = value;
                Invalidate();
            }
        }

        public BaseCellPanel()
        {
            InitializeComponent();
            lbName.Text = Cell_name;
            lbPrice.Text = Cell_price;
        }

    }
}
