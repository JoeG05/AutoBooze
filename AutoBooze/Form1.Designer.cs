namespace AutoBooze
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scotchPlainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chathamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGetInventory = new System.Windows.Forms.Button();
            this.buttonFillPerpetual = new System.Windows.Forms.Button();
            this.labelStore = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonFillOrder = new System.Windows.Forms.Button();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.buttonSendPerpetual = new System.Windows.Forms.Button();
            this.buttonSendOrder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.storeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(286, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scotchPlainsToolStripMenuItem,
            this.chathamToolStripMenuItem});
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // scotchPlainsToolStripMenuItem
            // 
            this.scotchPlainsToolStripMenuItem.Name = "scotchPlainsToolStripMenuItem";
            this.scotchPlainsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.scotchPlainsToolStripMenuItem.Text = "Scotch Plains";
            this.scotchPlainsToolStripMenuItem.Click += new System.EventHandler(this.scotchPlainsToolStripMenuItem_Click);
            // 
            // chathamToolStripMenuItem
            // 
            this.chathamToolStripMenuItem.Name = "chathamToolStripMenuItem";
            this.chathamToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.chathamToolStripMenuItem.Text = "Chatham";
            this.chathamToolStripMenuItem.Click += new System.EventHandler(this.chathamToolStripMenuItem_Click);
            // 
            // buttonGetInventory
            // 
            this.buttonGetInventory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGetInventory.Location = new System.Drawing.Point(15, 226);
            this.buttonGetInventory.Name = "buttonGetInventory";
            this.buttonGetInventory.Size = new System.Drawing.Size(82, 23);
            this.buttonGetInventory.TabIndex = 7;
            this.buttonGetInventory.Text = "Get Inventory";
            this.buttonGetInventory.UseVisualStyleBackColor = true;
            this.buttonGetInventory.Click += new System.EventHandler(this.buttonGetInventory_Click);
            // 
            // buttonFillPerpetual
            // 
            this.buttonFillPerpetual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonFillPerpetual.Location = new System.Drawing.Point(103, 226);
            this.buttonFillPerpetual.Name = "buttonFillPerpetual";
            this.buttonFillPerpetual.Size = new System.Drawing.Size(82, 23);
            this.buttonFillPerpetual.TabIndex = 8;
            this.buttonFillPerpetual.Text = "Fill Perpetual";
            this.buttonFillPerpetual.UseVisualStyleBackColor = true;
            this.buttonFillPerpetual.Click += new System.EventHandler(this.buttonFillPerpetual_Click);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Location = new System.Drawing.Point(9, 33);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(93, 13);
            this.labelStore.TabIndex = 9;
            this.labelStore.Text = "No store selected.";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 56);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(38, 13);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "status:";
            // 
            // buttonFillOrder
            // 
            this.buttonFillOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonFillOrder.Location = new System.Drawing.Point(191, 226);
            this.buttonFillOrder.Name = "buttonFillOrder";
            this.buttonFillOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonFillOrder.TabIndex = 11;
            this.buttonFillOrder.Text = "Fill Order";
            this.buttonFillOrder.UseVisualStyleBackColor = true;
            this.buttonFillOrder.Click += new System.EventHandler(this.buttonFillOrder_Click);
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Location = new System.Drawing.Point(12, 72);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(254, 148);
            this.richTextBoxStatus.TabIndex = 12;
            this.richTextBoxStatus.Text = "";
            // 
            // buttonSendPerpetual
            // 
            this.buttonSendPerpetual.Location = new System.Drawing.Point(55, 255);
            this.buttonSendPerpetual.Name = "buttonSendPerpetual";
            this.buttonSendPerpetual.Size = new System.Drawing.Size(89, 23);
            this.buttonSendPerpetual.TabIndex = 13;
            this.buttonSendPerpetual.Text = "Send Perpetual";
            this.buttonSendPerpetual.UseVisualStyleBackColor = true;
            this.buttonSendPerpetual.Click += new System.EventHandler(this.buttonSendPerpetual_Click);
            // 
            // buttonSendOrder
            // 
            this.buttonSendOrder.Location = new System.Drawing.Point(150, 255);
            this.buttonSendOrder.Name = "buttonSendOrder";
            this.buttonSendOrder.Size = new System.Drawing.Size(89, 23);
            this.buttonSendOrder.TabIndex = 14;
            this.buttonSendOrder.Text = "Send Order";
            this.buttonSendOrder.UseVisualStyleBackColor = true;
            this.buttonSendOrder.Click += new System.EventHandler(this.buttonSendOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 293);
            this.Controls.Add(this.buttonSendOrder);
            this.Controls.Add(this.buttonSendPerpetual);
            this.Controls.Add(this.richTextBoxStatus);
            this.Controls.Add(this.buttonFillOrder);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.buttonFillPerpetual);
            this.Controls.Add(this.buttonGetInventory);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AutoBooze";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scotchPlainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chathamToolStripMenuItem;
        private System.Windows.Forms.Button buttonGetInventory;
        private System.Windows.Forms.Button buttonFillPerpetual;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonFillOrder;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Button buttonSendPerpetual;
        private System.Windows.Forms.Button buttonSendOrder;
    }
}

