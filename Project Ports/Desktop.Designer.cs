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
            this.components = new System.ComponentModel.Container();
            this.appMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ltime = new System.Windows.Forms.Label();
            this.dclock = new System.Windows.Forms.Timer(this.components);
            this.hijackScreen = new System.Windows.Forms.Panel();
            this.hijackLabel = new System.Windows.Forms.Label();
            this.hijackStoryline = new System.Windows.Forms.Label();
            this.textgen = new System.Windows.Forms.Timer(this.components);
            this.appMenu.SuspendLayout();
            this.hijackScreen.SuspendLayout();
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
            this.terminalToolStripMenuItem,
            this.testWindowToolStripMenuItem,
            this.chatterToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.terminalToolStripMenuItem.Text = "Terminal";
            this.terminalToolStripMenuItem.Click += new System.EventHandler(this.terminalToolStripMenuItem_Click);
            // 
            // testWindowToolStripMenuItem
            // 
            this.testWindowToolStripMenuItem.Name = "testWindowToolStripMenuItem";
            this.testWindowToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.testWindowToolStripMenuItem.Text = "TestWindow";
            this.testWindowToolStripMenuItem.Click += new System.EventHandler(this.testWindowToolStripMenuItem_Click);
            // 
            // chatterToolStripMenuItem
            // 
            this.chatterToolStripMenuItem.Name = "chatterToolStripMenuItem";
            this.chatterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.chatterToolStripMenuItem.Text = "Chatter";
            this.chatterToolStripMenuItem.Click += new System.EventHandler(this.chatterToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
            this.ltime.Location = new System.Drawing.Point(742, 6);
            this.ltime.Name = "ltime";
            this.ltime.Size = new System.Drawing.Size(53, 13);
            this.ltime.TabIndex = 1;
            this.ltime.Text = "00:00 AM";
            this.ltime.Click += new System.EventHandler(this.label1_Click);
            // 
            // dclock
            // 
            this.dclock.Tick += new System.EventHandler(this.dclock_Tick);
            // 
            // hijackScreen
            // 
            this.hijackScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hijackScreen.BackColor = System.Drawing.Color.Black;
            this.hijackScreen.Controls.Add(this.hijackStoryline);
            this.hijackScreen.Controls.Add(this.hijackLabel);
            this.hijackScreen.Location = new System.Drawing.Point(0, 0);
            this.hijackScreen.Name = "hijackScreen";
            this.hijackScreen.Size = new System.Drawing.Size(800, 449);
            this.hijackScreen.TabIndex = 2;
            // 
            // hijackLabel
            // 
            this.hijackLabel.AutoSize = true;
            this.hijackLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hijackLabel.ForeColor = System.Drawing.Color.Red;
            this.hijackLabel.Location = new System.Drawing.Point(12, 11);
            this.hijackLabel.Name = "hijackLabel";
            this.hijackLabel.Size = new System.Drawing.Size(259, 15);
            this.hijackLabel.TabIndex = 0;
            this.hijackLabel.Text = "SYSTEM ERROR 3923882: BEING HIJACKED";
            // 
            // hijackStoryline
            // 
            this.hijackStoryline.AutoSize = true;
            this.hijackStoryline.Location = new System.Drawing.Point(12, 40);
            this.hijackStoryline.Name = "hijackStoryline";
            this.hijackStoryline.Size = new System.Drawing.Size(75, 13);
            this.hijackStoryline.TabIndex = 1;
            this.hijackStoryline.Text = "hijackStoryline";
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hijackScreen);
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
            this.hijackScreen.ResumeLayout(false);
            this.hijackScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip appMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label ltime;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private System.Windows.Forms.Timer dclock;
        private System.Windows.Forms.ToolStripMenuItem testWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatterToolStripMenuItem;
        private System.Windows.Forms.Panel hijackScreen;
        private System.Windows.Forms.Label hijackLabel;
        private System.Windows.Forms.Label hijackStoryline;
        private System.Windows.Forms.Timer textgen;
    }
}