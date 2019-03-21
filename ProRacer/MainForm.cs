//Ben Jokela Proracer Feb,2019
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
        private Participant partForm;
        private Race raceForm;
        private Sponsor sponForm;
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

        private void tsmiResults_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
            
        }

        private void tsmiRegistration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }


        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void tsmiFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiRaceParticipants_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void tsmiRaceByDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void tsmiParticipants_Click(object sender, EventArgs e)
        {
            if (partForm == null || partForm.IsDisposed)
            {
                partForm = new Participant(this);
            }
            if (tabControl1.Contains(partForm))
            {
                tabControl1.TabPages[partForm].Select();
            }
            else
            {
                tabControl1.TabPages.Add(partForm);
            }
        }
 
        private void tsmiRace_Click(object sender, EventArgs e)
        {
                if (raceForm == null || raceForm.IsDisposed)
                {
                    raceForm = new Race(this);
                }
                if (tabControl1.Contains(raceForm))
                {
                    tabControl1.TabPages[raceForm].Select();
                }
                else
                {
                    tabControl1.TabPages.Add(raceForm);
                }
            }

        private void tsmiSponsor_Click(object sender, EventArgs e)
        {
            if (sponForm == null || sponForm.IsDisposed)
            {
                sponForm = new Sponsor(this);
            }
            if (tabControl1.Contains(sponForm))
            {
                tabControl1.TabPages[sponForm].Select();
            }
            else
            {
                tabControl1.TabPages.Add(sponForm);
            }
        }
    }
}
