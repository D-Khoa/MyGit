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
    public partial class frmCrePlan : Form
    {
        sqlfirst sql = new sqlfirst();
        public frmCrePlan()
        {
            InitializeComponent();
            Storage sto = Storage.getStorage();
            txtPIC.Text = sto.id;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCre_Click(object sender, EventArgs e)
        {
            string cmd;
            try
            {
                if (txtPname.Text != "" && txtModel.Text != "")
                {
                    cmd = "insert into public.m_plan_created(plan_name, model, pic_id, date_create, date_original)"
                        + " values('" + txtPname.Text + "','" + txtModel.Text + "','" + txtPIC.Text + "','"
                        + dtCre.Text + "','" + dtOri.Text + "')";
                    sql.sqlExecuteNonQ(cmd);
                    MessageBox.Show("Đã tạo plan thành công!!!");
                }
                else
                    MessageBox.Show("Tên và model không thể để trống!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtCre_CloseUp(object sender, EventArgs e)
        {
            dtOri.Value = dtCre.Value.AddDays(30);
        }

        private void txtPIC_TextChanged(object sender, EventArgs e)
        {
            string cmd = "select user_name from public.m_user where pic_id ='" + txtPIC.Text + "'";
            lbname.Text = sql.sqlExecuteScalarString(cmd);
        }
    }
}
