using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBooze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data d = new Data();
            textBoxLastSunday.Text = d.getLastSunday();
            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
