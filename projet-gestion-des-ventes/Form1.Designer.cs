namespace projet_gestion_des_ventes
{
    partial class FormLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLog = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.emailLog = new System.Windows.Forms.Label();
            this.pwdLog = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.panelLog.Location = new System.Drawing.Point(0, 0);
            this.panelLog.Margin = new System.Windows.Forms.Padding(5);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(369, 735);
            this.panelLog.TabIndex = 0;
            this.panelLog.TabStop = true;
            this.panelLog.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLog_Paint);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.Title.Location = new System.Drawing.Point(677, 57);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(317, 65);
            this.Title.TabIndex = 1;
            this.Title.Text = "Techno Corner ";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(665, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(347, 37);
            this.txtEmail.TabIndex = 2;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(665, 409);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(347, 37);
            this.textPwd.TabIndex = 3;
            // 
            // emailLog
            // 
            this.emailLog.AutoSize = true;
            this.emailLog.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLog.Location = new System.Drawing.Point(665, 220);
            this.emailLog.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emailLog.Name = "emailLog";
            this.emailLog.Size = new System.Drawing.Size(113, 41);
            this.emailLog.TabIndex = 4;
            this.emailLog.Text = "E-mail :";
            this.emailLog.Click += new System.EventHandler(this.label2_Click);
            // 
            // pwdLog
            // 
            this.pwdLog.AutoSize = true;
            this.pwdLog.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pwdLog.Location = new System.Drawing.Point(665, 366);
            this.pwdLog.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pwdLog.Name = "pwdLog";
            this.pwdLog.Size = new System.Drawing.Size(194, 41);
            this.pwdLog.TabIndex = 5;
            this.pwdLog.Text = "Mot de passe :";
            this.pwdLog.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.btnLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLog.Location = new System.Drawing.Point(749, 534);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(191, 65);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Se Connecter";
            this.btnLog.UseVisualStyleBackColor = false;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1303, 730);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.pwdLog);
            this.Controls.Add(this.emailLog);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panelLog);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelLog;
        private Label Title;
        private TextBox txtEmail;
        private TextBox textPwd;
        private Label emailLog;
        private Label pwdLog;
        private Button btnLog;
    }
}