namespace Project_Ports
{
    partial class Boot
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
            this.txtBoot = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtBoot
            // 
            this.txtBoot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoot.BackColor = System.Drawing.Color.Black;
            this.txtBoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoot.ForeColor = System.Drawing.Color.White;
            this.txtBoot.Location = new System.Drawing.Point(12, 12);
            this.txtBoot.Name = "txtBoot";
            this.txtBoot.ReadOnly = true;
            this.txtBoot.Size = new System.Drawing.Size(565, 429);
            this.txtBoot.TabIndex = 0;
            this.txtBoot.Text = "";
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(589, 453);
            this.Controls.Add(this.txtBoot);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Boot";
            this.Text = "Boot";
            this.Load += new System.EventHandler(this.Boot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoot;
    }
}