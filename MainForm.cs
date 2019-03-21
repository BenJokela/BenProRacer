//Ben Jokela Proracer Feb 4,2019
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpStatusStrip();
            SplashScreen mySplash = new SplashScreen();
            Login myLogin = new Login();
            mySplash.ShowDialog();

            if(mySplash.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                myLogin.ShowDialog();
            }
            if(myLogin.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
        private void SetUpStatusStrip()
        {
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.Table;

            tss1.Text = DateTime.Now.ToShortDateString();
            tss1.TextAlign = ContentAlignment.MiddleLeft;
            tss1.BorderSides = ToolStripStatusLabelBorderSides.Right;

            tss2.Text = Environment.UserName;
            tss2.TextAlign = ContentAlignment.MiddleLeft;
            tss2.BorderSides = ToolStripStatusLabelBorderSides.Right;

            tss3.Text = "Position: 0 of 0";
            tss3.TextAlign = ContentAlignment.MiddleLeft;
            tss3.BorderSides = ToolStripStatusLabelBorderSides.Right;

            tss4.Text = "OK";
            tss4.TextAlign = ContentAlignment.MiddleRight;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rptForm = new Reports();
            rptForm.Show();
        }

        private void enterResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Results rsltForm = new Results();
            rsltForm.Show();
        }

        private void tlbReports_Click(object sender, EventArgs e)
        {
            Reports rptForm = new Reports();
            rptForm.Show();

        }

        private void tlbResults_Click(object sender, EventArgs e)
        {
            Results rsltForm = new Results();
            rsltForm.Show();

        }
    }
}
