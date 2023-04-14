namespace wf14_winforms_thread
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnCancle = new System.Windows.Forms.Button();
            this.PgbCalc = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Lblres = new System.Windows.Forms.Label();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력(수)";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(69, 41);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(101, 21);
            this.TxtNumber.TabIndex = 1;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(252, 41);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 21);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "시작";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnCancle
            // 
            this.BtnCancle.Location = new System.Drawing.Point(333, 41);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(75, 21);
            this.BtnCancle.TabIndex = 3;
            this.BtnCancle.Text = "취소";
            this.BtnCancle.UseVisualStyleBackColor = true;
            this.BtnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // PgbCalc
            // 
            this.PgbCalc.Location = new System.Drawing.Point(14, 82);
            this.PgbCalc.Name = "PgbCalc";
            this.PgbCalc.Size = new System.Drawing.Size(394, 23);
            this.PgbCalc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "결과";
            // 
            // Lblres
            // 
            this.Lblres.AutoSize = true;
            this.Lblres.Location = new System.Drawing.Point(56, 123);
            this.Lblres.Name = "Lblres";
            this.Lblres.Size = new System.Drawing.Size(11, 12);
            this.Lblres.TabIndex = 6;
            this.Lblres.Text = "0";
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 162);
            this.Controls.Add(this.Lblres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PgbCalc);
            this.Controls.Add(this.BtnCancle);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Background Worker 테스트";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnCancle;
        private System.Windows.Forms.ProgressBar PgbCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lblres;
        private System.ComponentModel.BackgroundWorker Worker;
    }
}

