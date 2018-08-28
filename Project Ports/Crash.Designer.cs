namespace Project_Ports
{
    partial class Crash
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
            this.lbCrash = new System.Windows.Forms.Label();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCrash
            // 
            this.lbCrash.AutoSize = true;
            this.lbCrash.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrash.ForeColor = System.Drawing.Color.Red;
            this.lbCrash.Location = new System.Drawing.Point(12, 9);
            this.lbCrash.Name = "lbCrash";
            this.lbCrash.Size = new System.Drawing.Size(406, 168);
            this.lbCrash.TabIndex = 0;
            this.lbCrash.Text = "PortOS.GUI has crashed....\r\n\r\nSYSTEM ERROR: CRASHED\r\n\r\nYou just lost the game :(\r" +
    "\n\r\nPress the button to start over...";
            // 
            // btnStartOver
            // 
            this.btnStartOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartOver.ForeColor = System.Drawing.Color.White;
            this.btnStartOver.Location = new System.Drawing.Point(619, 430);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(75, 23);
            this.btnStartOver.TabIndex = 1;
            this.btnStartOver.Text = "Start Over";
            this.btnStartOver.UseVisualStyleBackColor = true;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // Crash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 465);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.lbCrash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crash";
            this.Text = "Crash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCrash;
        private System.Windows.Forms.Button btnStartOver;
    }
}