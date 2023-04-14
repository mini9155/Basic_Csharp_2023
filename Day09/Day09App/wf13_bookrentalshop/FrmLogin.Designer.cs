namespace wf13_bookrentalshop
{
    partial class FrmLogin
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
            this.lbId = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbpwd = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(0, 25);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(69, 12);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "유저 아이디";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(75, 22);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(130, 21);
            this.txtid.TabIndex = 1;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(75, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(62, 21);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbpwd
            // 
            this.lbpwd.AutoSize = true;
            this.lbpwd.Location = new System.Drawing.Point(16, 73);
            this.lbpwd.Name = "lbpwd";
            this.lbpwd.Size = new System.Drawing.Size(53, 12);
            this.lbpwd.TabIndex = 0;
            this.lbpwd.Text = "패스워드";
            this.lbpwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbpwd.Click += new System.EventHandler(this.Txtpwd_Click);
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(75, 70);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '●';
            this.txtpw.Size = new System.Drawing.Size(130, 21);
            this.txtpw.TabIndex = 2;
            this.txtpw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpw_KeyPress);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(143, 127);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(62, 21);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 160);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbpwd);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbId);
            this.Name = "FrmLogin";
            this.Text = "로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbpwd;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Button btnCancle;
    }
}