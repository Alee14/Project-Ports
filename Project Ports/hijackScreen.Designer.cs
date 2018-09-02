namespace Project_Ports
{
    partial class hijackScreen
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
            this.hijackPanel = new System.Windows.Forms.Panel();
            this.btnSkipHijack = new System.Windows.Forms.Button();
            this.txtHijack = new System.Windows.Forms.TextBox();
            this.hijackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hijackPanel
            // 
            this.hijackPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hijackPanel.BackColor = System.Drawing.Color.Black;
            this.hijackPanel.Controls.Add(this.btnSkipHijack);
            this.hijackPanel.Controls.Add(this.txtHijack);
            this.hijackPanel.Location = new System.Drawing.Point(0, 0);
            this.hijackPanel.Name = "hijackPanel";
            this.hijackPanel.Size = new System.Drawing.Size(986, 571);
            this.hijackPanel.TabIndex = 3;
            // 
            // btnSkipHijack
            // 
            this.btnSkipHijack.Font = new System.Drawing.Font("Consolas", 10F);
            this.btnSkipHijack.Location = new System.Drawing.Point(880, 531);
            this.btnSkipHijack.Name = "btnSkipHijack";
            this.btnSkipHijack.Size = new System.Drawing.Size(103, 37);
            this.btnSkipHijack.TabIndex = 4;
            this.btnSkipHijack.Text = "Skip";
            this.btnSkipHijack.UseVisualStyleBackColor = true;
            this.btnSkipHijack.Click += new System.EventHandler(this.btnSkipHijack_Click);
            // 
            // txtHijack
            // 
            this.txtHijack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHijack.BackColor = System.Drawing.Color.Black;
            this.txtHijack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHijack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHijack.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHijack.ForeColor = System.Drawing.Color.White;
            this.txtHijack.Location = new System.Drawing.Point(12, 12);
            this.txtHijack.Multiline = true;
            this.txtHijack.Name = "txtHijack";
            this.txtHijack.ReadOnly = true;
            this.txtHijack.Size = new System.Drawing.Size(957, 547);
            this.txtHijack.TabIndex = 3;
            // 
            // hijackScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 571);
            this.Controls.Add(this.hijackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hijackScreen";
            this.Text = "hijackScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.hijackScreen_Load);
            this.hijackPanel.ResumeLayout(false);
            this.hijackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hijackPanel;
        private System.Windows.Forms.TextBox txtHijack;
        private System.Windows.Forms.Button btnSkipHijack;
    }
}