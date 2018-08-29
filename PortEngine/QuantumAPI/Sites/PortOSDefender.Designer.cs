namespace PortEngine.QuantumAPI.Sites
{
    partial class PortOSDefender
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.posLogo = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.rtxtNews = new System.Windows.Forms.RichTextBox();
            this.lbNews = new System.Windows.Forms.Label();
            this.lbAbout = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // posLogo
            // 
            this.posLogo.AutoSize = true;
            this.posLogo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posLogo.ForeColor = System.Drawing.Color.LimeGreen;
            this.posLogo.Location = new System.Drawing.Point(21, 18);
            this.posLogo.Name = "posLogo";
            this.posLogo.Size = new System.Drawing.Size(190, 24);
            this.posLogo.TabIndex = 0;
            this.posLogo.Text = "PortOS Defender";
            // 
            // btnSignin
            // 
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Location = new System.Drawing.Point(725, 21);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(75, 23);
            this.btnSignin.TabIndex = 1;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = true;
            // 
            // rtxtNews
            // 
            this.rtxtNews.BackColor = System.Drawing.Color.Black;
            this.rtxtNews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtNews.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtxtNews.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNews.ForeColor = System.Drawing.Color.White;
            this.rtxtNews.Location = new System.Drawing.Point(25, 113);
            this.rtxtNews.Name = "rtxtNews";
            this.rtxtNews.ReadOnly = true;
            this.rtxtNews.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtNews.Size = new System.Drawing.Size(200, 288);
            this.rtxtNews.TabIndex = 2;
            this.rtxtNews.Text = "";
            // 
            // lbNews
            // 
            this.lbNews.AutoSize = true;
            this.lbNews.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNews.ForeColor = System.Drawing.Color.White;
            this.lbNews.Location = new System.Drawing.Point(21, 91);
            this.lbNews.Name = "lbNews";
            this.lbNews.Size = new System.Drawing.Size(108, 19);
            this.lbNews.TabIndex = 3;
            this.lbNews.Text = "Latest News";
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Consolas", 12F);
            this.lbAbout.ForeColor = System.Drawing.Color.White;
            this.lbAbout.Location = new System.Drawing.Point(251, 91);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(108, 19);
            this.lbAbout.TabIndex = 4;
            this.lbAbout.Text = "Who are we?";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(255, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(187, 288);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "We are a hacker group and the point of this is to defeat the A.H.G.";
            // 
            // PortOSDefender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbNews);
            this.Controls.Add(this.rtxtNews);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.posLogo);
            this.Name = "PortOSDefender";
            this.Size = new System.Drawing.Size(842, 452);
            this.Load += new System.EventHandler(this.PortOSDefender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label posLogo;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.RichTextBox rtxtNews;
        private System.Windows.Forms.Label lbNews;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
