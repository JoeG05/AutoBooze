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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scotchPlainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chathamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLastSunday = new System.Windows.Forms.Label();
            this.textBoxLastSunday = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
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
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.scotchPlainsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scotchPlainsToolStripMenuItem.Text = "Scotch Plains";
            // 
            // chathamToolStripMenuItem
            // 
            this.chathamToolStripMenuItem.Name = "chathamToolStripMenuItem";
            this.chathamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chathamToolStripMenuItem.Text = "Chatham";
            // 
            // labelLastSunday
            // 
            this.labelLastSunday.AutoSize = true;
            this.labelLastSunday.Location = new System.Drawing.Point(12, 69);
            this.labelLastSunday.Name = "labelLastSunday";
            this.labelLastSunday.Size = new System.Drawing.Size(66, 13);
            this.labelLastSunday.TabIndex = 1;
            this.labelLastSunday.Text = "Last Sunday";
            // 
            // textBoxLastSunday
            // 
            this.textBoxLastSunday.Location = new System.Drawing.Point(84, 69);
            this.textBoxLastSunday.Name = "textBoxLastSunday";
            this.textBoxLastSunday.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastSunday.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 309);
            this.Controls.Add(this.textBoxLastSunday);
            this.Controls.Add(this.labelLastSunday);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label labelLastSunday;
        private System.Windows.Forms.TextBox textBoxLastSunday;
    }
}

