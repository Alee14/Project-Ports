namespace Project_Ports
{
    partial class ChatApp
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
            this.txtSentMessages = new System.Windows.Forms.TextBox();
            this.txtMsgContents = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSendMSG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSentMessages
            // 
            this.txtSentMessages.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSentMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSentMessages.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.txtSentMessages.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSentMessages.Location = new System.Drawing.Point(136, 3);
            this.txtSentMessages.Multiline = true;
            this.txtSentMessages.Name = "txtSentMessages";
            this.txtSentMessages.ReadOnly = true;
            this.txtSentMessages.Size = new System.Drawing.Size(439, 187);
            this.txtSentMessages.TabIndex = 0;
            // 
            // txtMsgContents
            // 
            this.txtMsgContents.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMsgContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsgContents.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.txtMsgContents.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtMsgContents.Location = new System.Drawing.Point(136, 196);
            this.txtMsgContents.Name = "txtMsgContents";
            this.txtMsgContents.Size = new System.Drawing.Size(384, 18);
            this.txtMsgContents.TabIndex = 1;
            this.txtMsgContents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMsgContents_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "#test"});
            this.listBox1.Location = new System.Drawing.Point(4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 210);
            this.listBox1.TabIndex = 2;
            // 
            // btnSendMSG
            // 
            this.btnSendMSG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMSG.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.btnSendMSG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSendMSG.Location = new System.Drawing.Point(527, 197);
            this.btnSendMSG.Name = "btnSendMSG";
            this.btnSendMSG.Size = new System.Drawing.Size(48, 19);
            this.btnSendMSG.TabIndex = 3;
            this.btnSendMSG.Text = "Send";
            this.btnSendMSG.UseVisualStyleBackColor = true;
            this.btnSendMSG.Click += new System.EventHandler(this.btnSendMSG_Click);
            // 
            // ChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.btnSendMSG);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtMsgContents);
            this.Controls.Add(this.txtSentMessages);
            this.Name = "ChatApp";
            this.Size = new System.Drawing.Size(578, 219);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSentMessages;
        private System.Windows.Forms.TextBox txtMsgContents;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSendMSG;
    }
}
