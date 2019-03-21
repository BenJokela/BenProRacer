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
    public partial class Sponsor : Form
    {
        MainForm myParent;

        public Sponsor(MainForm parent)
        {
            myParent = parent;
            InitializeComponent();
        }

    }
}
