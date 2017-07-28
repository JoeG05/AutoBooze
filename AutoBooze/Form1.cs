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
        Config c = new Config();
        Email m = new Email();

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
            richTextBoxStatus.Text += "Loading config file.\n";
            string status = c.loadConfig(@"C:\Dropbox\Work\SP.config");
            richTextBoxStatus.Text += status;

            d.storeNum = 27;
            d.setReportLocation(@c.attributes["ReportLocation"]);
            d.setPerpetualLocation(@c.attributes["BlankPerpetualLocation"]);
            d.setPerpetualSaveAsLocation(@c.attributes["PerpetualSaveAs"]);
            d.setOrderLocation(@c.attributes["BlankOrderLocation"]);
            d.setOrderSaveAsLocation(@c.attributes["OrderSaveAs"]);
        }

        private void chathamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelStore.Text = "Chatham";
            richTextBoxStatus.Text += "Loading config file.\n";
            string status = c.loadConfig(@"C:\Dropbox\Work\Chatham.config");
            richTextBoxStatus.Text += status;

            d.storeNum = 24;
            d.setReportLocation(@c.attributes["ReportLocation"]);
            d.setPerpetualLocation(@c.attributes["BlankPerpetualLocation"]);
            d.setPerpetualSaveAsLocation(@c.attributes["PerpetualSaveAs"]);
            d.setOrderLocation(@c.attributes["BlankOrderLocation"]);
            d.setOrderSaveAsLocation(@c.attributes[("OrderSaveAs")]);
        }

        private void buttonGetInventory_Click(object sender, EventArgs e)
        {
            if (d.reportLocation == "")
            {
                richTextBoxStatus.Text += "Select Location.\n";
                return;
            }
            if (!(File.Exists(d.reportLocation)))
            {
                richTextBoxStatus.Text += "Report not found.\n";
                return;
            }
            richTextBoxStatus.Text += "Loading Inventory\n";
            d.getInventory();
            richTextBoxStatus.Text += "Inventory Loaded\n";
        }

        private void buttonFillPerpetual_Click(object sender, EventArgs e)
        {
            if (!(File.Exists(d.perpetualLocation)))
            {
                richTextBoxStatus.Text += "Perpetual not found.\n";
                return;
            }
            richTextBoxStatus.Text += "Filling perpetual\n";
            d.fillPerpetual(d.storeNum);
            richTextBoxStatus.Text += "Perpetual Completed\n";
            d.finishPerpetual();
            richTextBoxStatus.Text += "Last weeks perpetual finished\n";
        }

        private void buttonFillOrder_Click(object sender, EventArgs e)
        {
            

            if (!(File.Exists(d.orderLocation)))
            {
                richTextBoxStatus.Text += "Order guide not found.\n";
                return;
            }
            richTextBoxStatus.Text += "Filling Order Guide\n";
            d.fillOrderSheet();
            richTextBoxStatus.Text += "Order Guide Filled\n";
        }

        private void buttonSendPerpetual_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSendOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutText = "Test";
            MessageBox.Show(aboutText, "AutoBooze v1.0.1");
            
        }

        private void chathamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string configLocation = @"C:\Dropbox\Work\Chatham.config";
            if (!(File.Exists(configLocation)))
            {
                richTextBoxStatus.Text += "Config file not found.\n";
                return;
            }
            System.Diagnostics.Process.Start(configLocation);
        }

        private void scotchPlainsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string configLocation = @"C:\Dropbox\Work\SP.config";
            if (!(File.Exists(configLocation)))
            {
                richTextBoxStatus.Text += "Config file not found.\n";
                return;
            }
            System.Diagnostics.Process.Start(configLocation);
        }
    }
}
