namespace PortEngine.QuantumAPI.Sites
{
    partial class QuantumISP
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
            this.lblQuantumISPTitle = new System.Windows.Forms.Label();
            this.lblQuantumISPSubtitle = new System.Windows.Forms.Label();
            this.lblYourPlan = new System.Windows.Forms.Label();
            this.btnUnsub = new System.Windows.Forms.Button();
            this.lblBookmarks = new System.Windows.Forms.Label();
            this.lblMalwarebitsHyperlink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuantumISPTitle
            // 
            this.lblQuantumISPTitle.AutoSize = true;
            this.lblQuantumISPTitle.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantumISPTitle.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblQuantumISPTitle.Location = new System.Drawing.Point(20, 21);
            this.lblQuantumISPTitle.Name = "lblQuantumISPTitle";
            this.lblQuantumISPTitle.Size = new System.Drawing.Size(359, 37);
            this.lblQuantumISPTitle.TabIndex = 0;
            this.lblQuantumISPTitle.Text = "Quantum Connections";
            // 
            // lblQuantumISPSubtitle
            // 
            this.lblQuantumISPSubtitle.AutoSize = true;
            this.lblQuantumISPSubtitle.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lblQuantumISPSubtitle.Location = new System.Drawing.Point(373, 35);
            this.lblQuantumISPSubtitle.Name = "lblQuantumISPSubtitle";
            this.lblQuantumISPSubtitle.Size = new System.Drawing.Size(350, 19);
            this.lblQuantumISPSubtitle.TabIndex = 1;
            this.lblQuantumISPSubtitle.Text = "Cheap access to the QuantumNet!";
            // 
            // lblYourPlan
            // 
            this.lblYourPlan.AutoSize = true;
            this.lblYourPlan.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourPlan.Location = new System.Drawing.Point(27, 89);
            this.lblYourPlan.Name = "lblYourPlan";
            this.lblYourPlan.Size = new System.Drawing.Size(161, 23);
            this.lblYourPlan.TabIndex = 2;
            this.lblYourPlan.Text = "YOUR PLAN: Mega";
            // 
            // btnUnsub
            // 
            this.btnUnsub.Location = new System.Drawing.Point(31, 144);
            this.btnUnsub.Name = "btnUnsub";
            this.btnUnsub.Size = new System.Drawing.Size(75, 23);
            this.btnUnsub.TabIndex = 3;
            this.btnUnsub.Text = "Unsubscribe";
            this.btnUnsub.UseVisualStyleBackColor = true;
            this.btnUnsub.Click += new System.EventHandler(this.btnUnsub_Click);
            // 
            // lblBookmarks
            // 
            this.lblBookmarks.AutoSize = true;
            this.lblBookmarks.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookmarks.Location = new System.Drawing.Point(27, 224);
            this.lblBookmarks.Name = "lblBookmarks";
            this.lblBookmarks.Size = new System.Drawing.Size(101, 23);
            this.lblBookmarks.TabIndex = 4;
            this.lblBookmarks.Text = "Bookmarks";
            // 
            // lblMalwarebitsHyperlink
            // 
            this.lblMalwarebitsHyperlink.AutoSize = true;
            this.lblMalwarebitsHyperlink.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.lblMalwarebitsHyperlink.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMalwarebitsHyperlink.Location = new System.Drawing.Point(27, 250);
            this.lblMalwarebitsHyperlink.Name = "lblMalwarebitsHyperlink";
            this.lblMalwarebitsHyperlink.Size = new System.Drawing.Size(198, 16);
            this.lblMalwarebitsHyperlink.TabIndex = 5;
            this.lblMalwarebitsHyperlink.Text = "qt.malwarebits/home";
            this.lblMalwarebitsHyperlink.Click += new System.EventHandler(this.lblMalwarebitsHyperlink_Click);
            // 
            // QuantumISP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMalwarebitsHyperlink);
            this.Controls.Add(this.lblBookmarks);
            this.Controls.Add(this.btnUnsub);
            this.Controls.Add(this.lblYourPlan);
            this.Controls.Add(this.lblQuantumISPSubtitle);
            this.Controls.Add(this.lblQuantumISPTitle);
            this.Name = "QuantumISP";
            this.Size = new System.Drawing.Size(842, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantumISPTitle;
        private System.Windows.Forms.Label lblQuantumISPSubtitle;
        private System.Windows.Forms.Label lblYourPlan;
        private System.Windows.Forms.Button btnUnsub;
        private System.Windows.Forms.Label lblBookmarks;
        private System.Windows.Forms.Label lblMalwarebitsHyperlink;
    }
}
