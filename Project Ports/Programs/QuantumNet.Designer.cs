namespace Project_Ports {
    partial class QuantumNet
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlSiteContents = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(842, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // pnlSiteContents
            // 
            this.pnlSiteContents.Location = new System.Drawing.Point(4, 31);
            this.pnlSiteContents.Name = "pnlSiteContents";
            this.pnlSiteContents.Size = new System.Drawing.Size(842, 452);
            this.pnlSiteContents.TabIndex = 1;
            // 
            // QuantumNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSiteContents);
            this.Controls.Add(this.txtAddress);
            this.Name = "QuantumNet";
            this.Size = new System.Drawing.Size(849, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel pnlSiteContents;
    }
}
