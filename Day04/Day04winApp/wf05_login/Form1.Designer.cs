namespace wf05_login
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbId = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbPw = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lbres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(27, 29);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(41, 12);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "아이디";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(176, 112);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "로그인";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lbPw
            // 
            this.lbPw.AutoSize = true;
            this.lbPw.Location = new System.Drawing.Point(27, 76);
            this.lbPw.Name = "lbPw";
            this.lbPw.Size = new System.Drawing.Size(53, 12);
            this.lbPw.TabIndex = 0;
            this.lbPw.Text = "패스워드";
            // 
            // txtstatus
            // 
            this.txtstatus.AutoSize = true;
            this.txtstatus.Location = new System.Drawing.Point(174, 156);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(0, 12);
            this.txtstatus.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(97, 73);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(100, 21);
            this.txtPw.TabIndex = 5;
            this.txtPw.TextChanged += new System.EventHandler(this.txtPw_TextChanged_1);
            // 
            // lbres
            // 
            this.lbres.AutoSize = true;
            this.lbres.Location = new System.Drawing.Point(176, 142);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(0, 12);
            this.lbres.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 184);
            this.Controls.Add(this.lbres);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbPw);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbPw;
        private System.Windows.Forms.Label txtstatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lbres;
    }
}

