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

            d.setReportLocation(@c.attributes["ReportLocation"]);
            d.setPerpetualLocation(@c.attributes["BlankPerpetualLocation"]);
            d.setPerpetualSaveAsLocation(@c.attributes["PerpetualSaveAs"]);
            d.setOrderLocation(@c.attributes["BlankOrderLocation"]);
            d.setOrderSaveAsLocation(@c.attributes["OrderSaveAs"]);
        }

        private void chathamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelStore.Text = "Chatham";
            richTextBoxStatus.Text += "Loading config file.";
            string status = c.loadConfig(@"C:\Dropbox\Work\Chatham.config");
            richTextBoxStatus.Text += status;

            d.setReportLocation(@c.attributes["ReportLocation"]);
            d.setPerpetualLocation(@c.attributes["BlankPerpetualLocation"]);
            d.setPerpetualSaveAsLocation(@c.attributes["PerpetualSaveAs"]);
        }

        private void buttonGetInventory_Click(object sender, EventArgs e)
        {
            if (d.reportLocation == "")
            {
                richTextBoxStatus.Text += "Select Location.\n";
                return;
            }
            richTextBoxStatus.Text += "Loading Inventory\n";
            d.getInventory();
            richTextBoxStatus.Text += "Inventory Loaded\n";
        }

        private void buttonFillPerpetual_Click(object sender, EventArgs e)
        {
            richTextBoxStatus.Text += "Filling perpetual\n";
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
            richTextBoxStatus.Text += "Filling Order Guide\n";
            d.fillOrderSheet();
            richTextBoxStatus.Text += "Order Guide Filled\n";
        }

        private void buttonSendPerpetual_Click(object sender, EventArgs e)
        {
            string subject = labelStore.Text + " perpetual";
            string body = "See attached. \nJoe";
            richTextBoxStatus.Text += "Coming soon\n";
            //m.sendEMail(c.attributes["FromAddress"], c.attributes["Password"], c.attributes["ToAddress"], subject, body, d.getperpetualSaveAsLocation());
        }

        private void buttonSendOrder_Click(object sender, EventArgs e)
        {
            string subject = labelStore.Text + " perpetual";
            string body = "See attached. \nJoe";
            richTextBoxStatus.Text += "Coming soon\n";
            //m.sendEMail(c.attributes["FromAddress"], c.attributes["Password"], c.attributes["ToAddress"], subject, body, d.getOrderSaveAsLocation());
        }
    }
}
