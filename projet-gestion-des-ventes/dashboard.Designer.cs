namespace projet_gestion_des_ventes
{
    partial class dashboard
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
            this.panelLog = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.panelLog.Location = new System.Drawing.Point(14, 1);
            this.panelLog.Margin = new System.Windows.Forms.Padding(5);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(369, 735);
            this.panelLog.TabIndex = 1;
            this.panelLog.TabStop = true;
            this.panelLog.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLog_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(384, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 37);
            this.panel1.TabIndex = 2;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "produit";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLog;
        private Panel panel1;
    }
}