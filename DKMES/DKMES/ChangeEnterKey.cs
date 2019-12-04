using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DKMES
{
    public partial class ChangeEnterKey : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public ChangeEnterKey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "select * from m_user";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                dataGridViewCommon1.DataSource = reader;
                MessageBox.Show("Connected!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
