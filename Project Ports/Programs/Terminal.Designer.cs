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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.terminalControl = new ConsoleControl.ConsoleControl();
            this.SuspendLayout();
            // 
            // terminalControl
            // 
            this.terminalControl.IsInputEnabled = true;
            this.terminalControl.Location = new System.Drawing.Point(0, 0);
            this.terminalControl.Name = "terminalControl";
            this.terminalControl.SendKeyboardCommandsToProcess = false;
            this.terminalControl.ShowDiagnostics = false;
            this.terminalControl.Size = new System.Drawing.Size(709, 441);
            this.terminalControl.TabIndex = 0;
            this.terminalControl.Load += new System.EventHandler(this.terminalControl_Load);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.terminalControl);
            this.Name = "Terminal";
            this.Size = new System.Drawing.Size(709, 441);
            this.ResumeLayout(false);

        }

        #endregion

        private ConsoleControl.ConsoleControl terminalControl;
    }
}
