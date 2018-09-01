namespace Project_Ports
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSetUsername = new System.Windows.Forms.TextBox();
            this.btnSetUsername = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // txtSetUsername
            // 
            this.txtSetUsername.Location = new System.Drawing.Point(25, 65);
            this.txtSetUsername.Multiline = true;
            this.txtSetUsername.Name = "txtSetUsername";
            this.txtSetUsername.Size = new System.Drawing.Size(163, 23);
            this.txtSetUsername.TabIndex = 2;
            // 
            // btnSetUsername
            // 
            this.btnSetUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUsername.Location = new System.Drawing.Point(204, 65);
            this.btnSetUsername.Name = "btnSetUsername";
            this.btnSetUsername.Size = new System.Drawing.Size(107, 23);
            this.btnSetUsername.TabIndex = 3;
            this.btnSetUsername.Text = "Set Username";
            this.btnSetUsername.UseVisualStyleBackColor = true;
            this.btnSetUsername.Click += new System.EventHandler(this.btnSetUsername_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnSetUsername);
            this.Controls.Add(this.txtSetUsername);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(664, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSetUsername;
        private System.Windows.Forms.Button btnSetUsername;
    }
}
