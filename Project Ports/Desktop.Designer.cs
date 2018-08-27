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
            this.ltime = new System.Windows.Forms.Label();
            this.dclock = new System.Windows.Forms.Timer(this.components);
            this.textgen = new System.Windows.Forms.Timer(this.components);
            this.appMenu = new System.Windows.Forms.Panel();
            this.programStrip = new System.Windows.Forms.ToolStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shutdownButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerName = new System.Windows.Forms.Label();
            this.taskBar = new System.Windows.Forms.Panel();
            this.appButton = new System.Windows.Forms.Button();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantumNetBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appMenu.SuspendLayout();
            this.programStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.taskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltime
            // 
            this.ltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ltime.AutoSize = true;
            this.ltime.BackColor = System.Drawing.Color.DarkGray;
            this.ltime.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltime.ForeColor = System.Drawing.Color.Black;
            this.ltime.Location = new System.Drawing.Point(991, 9);
            this.ltime.Name = "ltime";
            this.ltime.Size = new System.Drawing.Size(63, 15);
            this.ltime.TabIndex = 1;
            this.ltime.Text = "00:00 AM";
            // 
            // dclock
            // 
            this.dclock.Tick += new System.EventHandler(this.dclock_Tick);
            // 
            // appMenu
            // 
            this.appMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appMenu.Controls.Add(this.programStrip);
            this.appMenu.Controls.Add(this.panel2);
            this.appMenu.Controls.Add(this.panel1);
            this.appMenu.ForeColor = System.Drawing.Color.Black;
            this.appMenu.Location = new System.Drawing.Point(0, 32);
            this.appMenu.Name = "appMenu";
            this.appMenu.Size = new System.Drawing.Size(376, 429);
            this.appMenu.TabIndex = 3;
            // 
            // programStrip
            // 
            this.programStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.programStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.programStrip.Location = new System.Drawing.Point(9, 349);
            this.programStrip.Name = "programStrip";
            this.programStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.programStrip.Size = new System.Drawing.Size(88, 25);
            this.programStrip.TabIndex = 2;
            this.programStrip.Text = "toolStrip1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.shutdownButton);
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 52);
            this.panel2.TabIndex = 1;
            // 
            // shutdownButton
            // 
            this.shutdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownButton.ForeColor = System.Drawing.Color.White;
            this.shutdownButton.Location = new System.Drawing.Point(284, 14);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(79, 27);
            this.shutdownButton.TabIndex = 0;
            this.shutdownButton.Text = "Shutdown";
            this.shutdownButton.UseVisualStyleBackColor = true;
            this.shutdownButton.Click += new System.EventHandler(this.shutdownButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.playerName);
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 51);
            this.panel1.TabIndex = 0;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.ForeColor = System.Drawing.Color.White;
            this.playerName.Location = new System.Drawing.Point(24, 18);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(63, 13);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "playerName";
            // 
            // taskBar
            // 
            this.taskBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskBar.BackColor = System.Drawing.Color.DarkGray;
            this.taskBar.Controls.Add(this.appButton);
            this.taskBar.Controls.Add(this.ltime);
            this.taskBar.Location = new System.Drawing.Point(0, 0);
            this.taskBar.Name = "taskBar";
            this.taskBar.Size = new System.Drawing.Size(1066, 32);
            this.taskBar.TabIndex = 4;
            // 
            // appButton
            // 
            this.appButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appButton.ForeColor = System.Drawing.Color.Black;
            this.appButton.Location = new System.Drawing.Point(12, 6);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(107, 23);
            this.appButton.TabIndex = 2;
            this.appButton.Text = "Applications";
            this.appButton.UseVisualStyleBackColor = true;
            this.appButton.Click += new System.EventHandler(this.appButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminalToolStripMenuItem,
            this.testWindowToolStripMenuItem,
            this.chatterToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.quantumNetBrowserToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(76, 22);
            this.toolStripDropDownButton1.Text = "Programs";
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.terminalToolStripMenuItem.Text = "Terminal";
            this.terminalToolStripMenuItem.Click += new System.EventHandler(this.terminalToolStripMenuItem_Click_1);
            // 
            // testWindowToolStripMenuItem
            // 
            this.testWindowToolStripMenuItem.Name = "testWindowToolStripMenuItem";
            this.testWindowToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.testWindowToolStripMenuItem.Text = "TestWindow";
            this.testWindowToolStripMenuItem.Click += new System.EventHandler(this.testWindowToolStripMenuItem_Click_1);
            // 
            // chatterToolStripMenuItem
            // 
            this.chatterToolStripMenuItem.Name = "chatterToolStripMenuItem";
            this.chatterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.chatterToolStripMenuItem.Text = "Chatter";
            this.chatterToolStripMenuItem.Click += new System.EventHandler(this.chatterToolStripMenuItem_Click_1);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click_1);
            // 
            // quantumNetBrowserToolStripMenuItem
            // 
            this.quantumNetBrowserToolStripMenuItem.Name = "quantumNetBrowserToolStripMenuItem";
            this.quantumNetBrowserToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.quantumNetBrowserToolStripMenuItem.Text = "QuantumNet Browser";
            this.quantumNetBrowserToolStripMenuItem.Click += new System.EventHandler(this.quantumNetBrowserToolStripMenuItem_Click_1);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1066, 560);
            this.Controls.Add(this.taskBar);
            this.Controls.Add(this.appMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.Text = "Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Desktop_MouseClick);
            this.appMenu.ResumeLayout(false);
            this.appMenu.PerformLayout();
            this.programStrip.ResumeLayout(false);
            this.programStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.taskBar.ResumeLayout(false);
            this.taskBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ltime;
        private System.Windows.Forms.Timer dclock;
        private System.Windows.Forms.Timer textgen;
        private System.Windows.Forms.Panel appMenu;
        private System.Windows.Forms.Panel taskBar;
        private System.Windows.Forms.Button appButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button shutdownButton;
        private System.Windows.Forms.ToolStrip programStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantumNetBrowserToolStripMenuItem;
    }
}