namespace Project_Ports
{
    partial class Terminal
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
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTerminal
            // 
            this.txtTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTerminal.BackColor = System.Drawing.Color.Black;
            this.txtTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTerminal.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminal.ForeColor = System.Drawing.Color.White;
            this.txtTerminal.Location = new System.Drawing.Point(1, 0);
            this.txtTerminal.Multiline = true;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(555, 320);
            this.txtTerminal.TabIndex = 0;
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 321);
            this.Controls.Add(this.txtTerminal);
            this.Name = "Terminal";
            this.Text = "Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTerminal;
    }
}