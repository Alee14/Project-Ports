namespace Project_Ports
{
    partial class Desktop
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
            this.appMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ltime = new System.Windows.Forms.Label();
            this.appMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // appMenu
            // 
            this.appMenu.BackColor = System.Drawing.Color.Silver;
            this.appMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.appMenu.Location = new System.Drawing.Point(0, 0);
            this.appMenu.Name = "appMenu";
            this.appMenu.Size = new System.Drawing.Size(800, 24);
            this.appMenu.TabIndex = 0;
            this.appMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.shutdownToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noProgramsToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // noProgramsToolStripMenuItem
            // 
            this.noProgramsToolStripMenuItem.Name = "noProgramsToolStripMenuItem";
            this.noProgramsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.noProgramsToolStripMenuItem.Text = "No programs :(";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // ltime
            // 
            this.ltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ltime.AutoSize = true;
            this.ltime.BackColor = System.Drawing.Color.Silver;
            this.ltime.ForeColor = System.Drawing.Color.Black;
            this.ltime.Location = new System.Drawing.Point(753, 7);
            this.ltime.Name = "ltime";
            this.ltime.Size = new System.Drawing.Size(26, 13);
            this.ltime.TabIndex = 1;
            this.ltime.Text = "time";
            this.ltime.Click += new System.EventHandler(this.label1_Click);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltime);
            this.Controls.Add(this.appMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.appMenu;
            this.Name = "Desktop";
            this.Text = "Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.appMenu.ResumeLayout(false);
            this.appMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip appMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label ltime;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}