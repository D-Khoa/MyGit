using System;
using System.Windows.Forms;
using PC_QRCodeSystem.Model;

namespace PC_QRCodeSystem
{
    public partial class Login : Form
    {
        GetData getData = new GetData();

        public Login()
        {
            InitializeComponent();
            this.Text = lbTittle.Text + "-" + this.Text;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = null;
            txtUsername.Focus();
        }

        /// <summary>
        /// Press ENTER for jump to password textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
                AcceptButton = btnOK;
            }
        }

        /// <summary>
        /// Click button OK for login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //Check empty username
                if (!string.IsNullOrEmpty(txtUsername.Text))
                {
                    //Check login status
                    //If user is now online, then choose re-login or return
                    if (getData.CheckLogin(txtUsername.Text, txtpass.Text))
                    {
                        if (MessageBox.Show("The user is now online." + Environment.NewLine + "Are you want to re-login?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            txtpass.Clear();
                            return;
                        }
                    }
                    //Login and check password
                    getData.Login(txtUsername.Text, txtpass.Text);
                    //Show main form
                    MainForm main = new MainForm();
                    this.Hide();
                    txtpass.Clear();
                    main.ShowDialog();
                    getData.LogOut();
                    this.Show();
                    this.Focus();
                }
                else
                {
                    MessageBox.Show("Please fill username.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    this.AcceptButton = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Click button Cancel for return
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
