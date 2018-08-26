namespace PortEngine.QuantumAPI.Sites
{
    partial class _404Error
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
            this.lbl404 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl404
            // 
            this.lbl404.AutoSize = true;
            this.lbl404.Font = new System.Drawing.Font("Consolas", 72F);
            this.lbl404.Location = new System.Drawing.Point(304, 35);
            this.lbl404.Name = "lbl404";
            this.lbl404.Size = new System.Drawing.Size(259, 112);
            this.lbl404.TabIndex = 0;
            this.lbl404.Text = "404!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 34F);
            this.label1.Location = new System.Drawing.Point(237, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "You hit a snag.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20F);
            this.label2.Location = new System.Drawing.Point(174, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lost? Visit quantumconnections.qt";
            // 
            // _404Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl404);
            this.Name = "_404Error";
            this.Size = new System.Drawing.Size(842, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl404;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
