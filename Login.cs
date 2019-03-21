//Ben Jokela ProRacer iteration 1 Feb 3, 2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProRacer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - Login";
            //autopopulate the username with current logged in user.

            txtUserName.Text = Environment.UserName;
            //this will mask the password box with bullets.
            txtPassword.UseSystemPasswordChar = true;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //in future, we will be getting this info from a database.
                if (txtUserName.Text == Environment.UserName && txtPassword.Text == Properties.Settings.Default.PW)
                {
                    //login succesful
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
