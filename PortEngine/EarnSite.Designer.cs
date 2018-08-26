namespace PortEngine
{
    partial class EarnSite
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
            this.btnOpenGTN = new System.Windows.Forms.Button();
            this.btnLaunchDTA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenGTN
            // 
            this.btnOpenGTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenGTN.Location = new System.Drawing.Point(3, 3);
            this.btnOpenGTN.Name = "btnOpenGTN";
            this.btnOpenGTN.Size = new System.Drawing.Size(160, 39);
            this.btnOpenGTN.TabIndex = 0;
            this.btnOpenGTN.Text = "Guess the Number";
            this.btnOpenGTN.UseVisualStyleBackColor = true;
            // 
            // btnLaunchDTA
            // 
            this.btnLaunchDTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchDTA.Location = new System.Drawing.Point(3, 48);
            this.btnLaunchDTA.Name = "btnLaunchDTA";
            this.btnLaunchDTA.Size = new System.Drawing.Size(160, 39);
            this.btnLaunchDTA.TabIndex = 1;
            this.btnLaunchDTA.Text = "Dodge the Ad";
            this.btnLaunchDTA.UseVisualStyleBackColor = true;
            // 
            // EarnSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLaunchDTA);
            this.Controls.Add(this.btnOpenGTN);
            this.Name = "EarnSite";
            this.Size = new System.Drawing.Size(842, 452);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenGTN;
        private System.Windows.Forms.Button btnLaunchDTA;
    }
}
