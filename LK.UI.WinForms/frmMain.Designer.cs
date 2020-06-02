namespace LK.UI.WinForms
{
    partial class frmMain
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
            this.базаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.трафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаToolStripMenuItem
            // 
            this.базаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абонентыToolStripMenuItem,
            this.аккаунтыToolStripMenuItem,
            this.тарифыToolStripMenuItem,
            this.трафикToolStripMenuItem});
            this.базаToolStripMenuItem.Name = "базаToolStripMenuItem";
            this.базаToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.базаToolStripMenuItem.Text = "База";
            // 
            // абонентыToolStripMenuItem
            // 
            this.абонентыToolStripMenuItem.Name = "абонентыToolStripMenuItem";
            this.абонентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.абонентыToolStripMenuItem.Text = "Абоненты";
            this.абонентыToolStripMenuItem.Click += new System.EventHandler(this.АбонентыToolStripMenuItem_Click);
            // 
            // аккаунтыToolStripMenuItem
            // 
            this.аккаунтыToolStripMenuItem.Name = "аккаунтыToolStripMenuItem";
            this.аккаунтыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.аккаунтыToolStripMenuItem.Text = "Аккаунты";
            this.аккаунтыToolStripMenuItem.Click += new System.EventHandler(this.АккаунтыToolStripMenuItem_Click);
            // 
            // тарифыToolStripMenuItem
            // 
            this.тарифыToolStripMenuItem.Name = "тарифыToolStripMenuItem";
            this.тарифыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тарифыToolStripMenuItem.Text = "Тарифы";
            this.тарифыToolStripMenuItem.Click += new System.EventHandler(this.ТарифыToolStripMenuItem_Click);
            // 
            // трафикToolStripMenuItem
            // 
            this.трафикToolStripMenuItem.Name = "трафикToolStripMenuItem";
            this.трафикToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.трафикToolStripMenuItem.Text = "Трафик";
            this.трафикToolStripMenuItem.Click += new System.EventHandler(this.ТрафикToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аккаунтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тарифыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem трафикToolStripMenuItem;
    }
}