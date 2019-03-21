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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            label1.Text = Application.ProductName;
            label2.Text = Application.ProductVersion;
            label3.Text = Application.CompanyName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
