using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoBooze
{
    public partial class Form1 : Form
    {
        Data d = new Data();
        public Form1()
        {
            InitializeComponent();
            
            
            
            
        }
        
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scotchPlainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelStore.Text = "Scotch Plains";
            d.setReportLocation(@"C:\Dropbox\Work\Inventory\Report.txt");
            d.setPerpetualLocation(@"C:\Dropbox\Work\Inventory\Perpetual-Blank.xlsx");
            d.setPerpetualSaveAsLocation(@"C:\Dropbox\Work\Inventory\Test\");
            d.setOrderLocation(@"C:\Dropbox\Work\Inventory\SPBlank.xls");
            d.setOrderSaveAsLocation(@"C:\Dropbox\Work\Inventory\Test\");
        }

        private void chathamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelStore.Text = "Chatham";
            d.setReportLocation(@"C:\Dropbox\Work\Chatham\Report.txt");
            d.setPerpetualLocation(@"C:\Dropbox\Work\Chatham\Perpetual-Blank.xlsx");
            d.setPerpetualSaveAsLocation(@"C:\Dropbox\Work\Chatham\Test\");
        }

        private void buttonGetInventory_Click(object sender, EventArgs e)
        {
            if (d.reportLocation == "")
            {
                richTextBoxStatus.Text += "Select Location.\n";
                return;
            }
            d.getInventory();
            richTextBoxStatus.Text += "Inventory Loaded\n";
        }

        private void buttonFillPerpetual_Click(object sender, EventArgs e)
        {
            d.fillPerpetual();
            richTextBoxStatus.Text += "Perpetual Completed\n";
        }

        private void buttonFillOrder_Click(object sender, EventArgs e)
        {
            if (labelStore.Text == "Chatham")
            {
                richTextBoxStatus.Text += "No order guide set up\n";
                return;
            }
            d.fillOrderSheet();
            richTextBoxStatus.Text += "Order Guide Filled\n";
        }
    }
}
