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
            this.appMenu = new System.Windows.Forms.Panel();
            this.btnFileManager = new System.Windows.Forms.Button();
            this.btnTestWindow = new System.Windows.Forms.Button();
            this.btnCrash = new System.Windows.Forms.Button();
            this.btnhijack2 = new System.Windows.Forms.Button();
            this.shutdownButton = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.Label();
            this.appMenuPanel2 = new System.Windows.Forms.PictureBox();
            this.appMenuPanel1 = new System.Windows.Forms.PictureBox();
            this.appMenuFrame1 = new System.Windows.Forms.PictureBox();
            this.appMenuFrame2 = new System.Windows.Forms.PictureBox();
            this.btnQuantumNet = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnChatter = new System.Windows.Forms.Button();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.lbPrograms = new System.Windows.Forms.Label();
            this.taskBar = new System.Windows.Forms.Panel();
            this.appButton = new System.Windows.Forms.Button();
            this.desktopWatermark = new System.Windows.Forms.Label();
            this.appMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appMenuPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenuPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenuFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenuFrame2)).BeginInit();
            this.taskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltime
            // 
            this.ltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ltime.AutoSize = true;
            this.ltime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ltime.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltime.ForeColor = System.Drawing.Color.White;
            this.ltime.Location = new System.Drawing.Point(991, 12);
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
            this.appMenu.BackColor = System.Drawing.Color.Black;
            this.appMenu.Controls.Add(this.btnFileManager);
            this.appMenu.Controls.Add(this.btnTestWindow);
            this.appMenu.Controls.Add(this.btnCrash);
            this.appMenu.Controls.Add(this.btnhijack2);
            this.appMenu.Controls.Add(this.shutdownButton);
            this.appMenu.Controls.Add(this.playerName);
            this.appMenu.Controls.Add(this.appMenuPanel2);
            this.appMenu.Controls.Add(this.appMenuPanel1);
            this.appMenu.Controls.Add(this.appMenuFrame1);
            this.appMenu.Controls.Add(this.appMenuFrame2);
            this.appMenu.Controls.Add(this.btnQuantumNet);
            this.appMenu.Controls.Add(this.btnSettings);
            this.appMenu.Controls.Add(this.btnChatter);
            this.appMenu.Controls.Add(this.btnTerminal);
            this.appMenu.Controls.Add(this.lbPrograms);
            this.appMenu.ForeColor = System.Drawing.Color.Black;
            this.appMenu.Location = new System.Drawing.Point(0, 38);
            this.appMenu.Name = "appMenu";
            this.appMenu.Size = new System.Drawing.Size(317, 429);
            this.appMenu.TabIndex = 3;
            // 
            // btnFileManager
            // 
            this.btnFileManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileManager.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnFileManager.ForeColor = System.Drawing.Color.White;
            this.btnFileManager.Location = new System.Drawing.Point(83, 106);
            this.btnFileManager.Name = "btnFileManager";
            this.btnFileManager.Size = new System.Drawing.Size(148, 43);
            this.btnFileManager.TabIndex = 15;
            this.btnFileManager.Text = "File Manager";
            this.btnFileManager.UseVisualStyleBackColor = true;
            this.btnFileManager.Click += new System.EventHandler(this.btnFileManager_Click);
            // 
            // btnTestWindow
            // 
            this.btnTestWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTestWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestWindow.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestWindow.ForeColor = System.Drawing.Color.White;
            this.btnTestWindow.Location = new System.Drawing.Point(23, 391);
            this.btnTestWindow.Name = "btnTestWindow";
            this.btnTestWindow.Size = new System.Drawing.Size(77, 23);
            this.btnTestWindow.TabIndex = 13;
            this.btnTestWindow.Text = "TestWindow";
            this.btnTestWindow.UseVisualStyleBackColor = false;
            this.btnTestWindow.Visible = false;
            this.btnTestWindow.Click += new System.EventHandler(this.btnTestWindow_Click);
            // 
            // btnCrash
            // 
            this.btnCrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrash.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnCrash.ForeColor = System.Drawing.Color.White;
            this.btnCrash.Location = new System.Drawing.Point(106, 391);
            this.btnCrash.Name = "btnCrash";
            this.btnCrash.Size = new System.Drawing.Size(75, 23);
            this.btnCrash.TabIndex = 7;
            this.btnCrash.Text = "Crash";
            this.btnCrash.UseVisualStyleBackColor = false;
            this.btnCrash.Visible = false;
            this.btnCrash.Click += new System.EventHandler(this.btnCrash_Click);
            // 
            // btnhijack2
            // 
            this.btnhijack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhijack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhijack2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhijack2.ForeColor = System.Drawing.Color.White;
            this.btnhijack2.Location = new System.Drawing.Point(187, 391);
            this.btnhijack2.Name = "btnhijack2";
            this.btnhijack2.Size = new System.Drawing.Size(113, 23);
            this.btnhijack2.TabIndex = 6;
            this.btnhijack2.Text = "Start Hijack 2";
            this.btnhijack2.UseVisualStyleBackColor = false;
            this.btnhijack2.Visible = false;
            this.btnhijack2.Click += new System.EventHandler(this.btnhijack2_Click);
            // 
            // shutdownButton
            // 
            this.shutdownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shutdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownButton.ForeColor = System.Drawing.Color.White;
            this.shutdownButton.Location = new System.Drawing.Point(220, 13);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(89, 29);
            this.shutdownButton.TabIndex = 0;
            this.shutdownButton.Text = "Shutdown";
            this.shutdownButton.UseVisualStyleBackColor = false;
            this.shutdownButton.Click += new System.EventHandler(this.shutdownButton_Click);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.Color.White;
            this.playerName.Location = new System.Drawing.Point(28, 17);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(99, 19);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "playerName";
            // 
            // appMenuPanel2
            // 
            this.appMenuPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appMenuPanel2.Location = new System.Drawing.Point(0, 376);
            this.appMenuPanel2.Name = "appMenuPanel2";
            this.appMenuPanel2.Size = new System.Drawing.Size(317, 53);
            this.appMenuPanel2.TabIndex = 7;
            this.appMenuPanel2.TabStop = false;
            // 
            // appMenuPanel1
            // 
            this.appMenuPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appMenuPanel1.Location = new System.Drawing.Point(0, 0);
            this.appMenuPanel1.Name = "appMenuPanel1";
            this.appMenuPanel1.Size = new System.Drawing.Size(317, 54);
            this.appMenuPanel1.TabIndex = 6;
            this.appMenuPanel1.TabStop = false;
            // 
            // appMenuFrame1
            // 
            this.appMenuFrame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appMenuFrame1.Location = new System.Drawing.Point(0, 50);
            this.appMenuFrame1.Name = "appMenuFrame1";
            this.appMenuFrame1.Size = new System.Drawing.Size(10, 327);
            this.appMenuFrame1.TabIndex = 14;
            this.appMenuFrame1.TabStop = false;
            // 
            // appMenuFrame2
            // 
            this.appMenuFrame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appMenuFrame2.Location = new System.Drawing.Point(306, 50);
            this.appMenuFrame2.Name = "appMenuFrame2";
            this.appMenuFrame2.Size = new System.Drawing.Size(10, 327);
            this.appMenuFrame2.TabIndex = 13;
            this.appMenuFrame2.TabStop = false;
            // 
            // btnQuantumNet
            // 
            this.btnQuantumNet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantumNet.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnQuantumNet.ForeColor = System.Drawing.Color.White;
            this.btnQuantumNet.Location = new System.Drawing.Point(83, 253);
            this.btnQuantumNet.Name = "btnQuantumNet";
            this.btnQuantumNet.Size = new System.Drawing.Size(148, 43);
            this.btnQuantumNet.TabIndex = 12;
            this.btnQuantumNet.Text = "QuantumNet Browser";
            this.btnQuantumNet.UseVisualStyleBackColor = true;
            this.btnQuantumNet.Click += new System.EventHandler(this.btnQuantumNet_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(83, 155);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(148, 43);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnChatter
            // 
            this.btnChatter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatter.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnChatter.ForeColor = System.Drawing.Color.White;
            this.btnChatter.Location = new System.Drawing.Point(83, 302);
            this.btnChatter.Name = "btnChatter";
            this.btnChatter.Size = new System.Drawing.Size(148, 43);
            this.btnChatter.TabIndex = 10;
            this.btnChatter.Text = "Chatter";
            this.btnChatter.UseVisualStyleBackColor = true;
            this.btnChatter.Click += new System.EventHandler(this.btnChatter_Click);
            // 
            // btnTerminal
            // 
            this.btnTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminal.ForeColor = System.Drawing.Color.White;
            this.btnTerminal.Location = new System.Drawing.Point(83, 204);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(148, 43);
            this.btnTerminal.TabIndex = 9;
            this.btnTerminal.Text = "Terminal";
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // lbPrograms
            // 
            this.lbPrograms.AutoSize = true;
            this.lbPrograms.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrograms.ForeColor = System.Drawing.Color.White;
            this.lbPrograms.Location = new System.Drawing.Point(114, 72);
            this.lbPrograms.Name = "lbPrograms";
            this.lbPrograms.Size = new System.Drawing.Size(81, 19);
            this.lbPrograms.TabIndex = 8;
            this.lbPrograms.Text = "Programs";
            this.lbPrograms.Click += new System.EventHandler(this.lbPrograms_Click);
            // 
            // taskBar
            // 
            this.taskBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskBar.Controls.Add(this.appButton);
            this.taskBar.Controls.Add(this.ltime);
            this.taskBar.Location = new System.Drawing.Point(0, 0);
            this.taskBar.Name = "taskBar";
            this.taskBar.Size = new System.Drawing.Size(1066, 38);
            this.taskBar.TabIndex = 4;
            // 
            // appButton
            // 
            this.appButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appButton.Font = new System.Drawing.Font("Consolas", 9.25F);
            this.appButton.ForeColor = System.Drawing.Color.White;
            this.appButton.Location = new System.Drawing.Point(12, 6);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(107, 26);
            this.appButton.TabIndex = 2;
            this.appButton.Text = "Applications";
            this.appButton.UseVisualStyleBackColor = true;
            this.appButton.Click += new System.EventHandler(this.appButton_Click);
            // 
            // desktopWatermark
            // 
            this.desktopWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.desktopWatermark.AutoSize = true;
            this.desktopWatermark.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopWatermark.ForeColor = System.Drawing.Color.White;
            this.desktopWatermark.Location = new System.Drawing.Point(854, 515);
            this.desktopWatermark.Name = "desktopWatermark";
            this.desktopWatermark.Size = new System.Drawing.Size(136, 18);
            this.desktopWatermark.TabIndex = 5;
            this.desktopWatermark.Text = "desktopWatermark";
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1066, 560);
            this.Controls.Add(this.desktopWatermark);
            this.Controls.Add(this.taskBar);
            this.Controls.Add(this.appMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.Text = "desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Desktop_MouseClick);
            this.appMenu.ResumeLayout(false);
            this.appMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appMenuPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenuPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenuFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenuFrame2)).EndInit();
            this.taskBar.ResumeLayout(false);
            this.taskBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ltime;
        private System.Windows.Forms.Timer dclock;
        private System.Windows.Forms.Panel appMenu;
        private System.Windows.Forms.Panel taskBar;
        private System.Windows.Forms.Button appButton;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Button shutdownButton;
        private System.Windows.Forms.Label desktopWatermark;
        private System.Windows.Forms.Button btnhijack2;
        private System.Windows.Forms.Button btnCrash;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.Label lbPrograms;
        private System.Windows.Forms.Button btnQuantumNet;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnChatter;
        private System.Windows.Forms.Button btnTestWindow;
        private System.Windows.Forms.PictureBox appMenuFrame1;
        private System.Windows.Forms.PictureBox appMenuFrame2;
        private System.Windows.Forms.PictureBox appMenuPanel2;
        private System.Windows.Forms.PictureBox appMenuPanel1;
        private System.Windows.Forms.Button btnFileManager;
    }
}