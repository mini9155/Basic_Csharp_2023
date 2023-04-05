namespace wf03_propoty
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
            this.GbxMain = new System.Windows.Forms.GroupBox();
            this.Nud1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.chkbold = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkita = new System.Windows.Forms.CheckBox();
            this.GbxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxMain
            // 
            this.GbxMain.Controls.Add(this.chkita);
            this.GbxMain.Controls.Add(this.Nud1);
            this.GbxMain.Controls.Add(this.label2);
            this.GbxMain.Controls.Add(this.TxtResult);
            this.GbxMain.Controls.Add(this.chkbold);
            this.GbxMain.Controls.Add(this.comboBox1);
            this.GbxMain.Controls.Add(this.label1);
            this.GbxMain.Location = new System.Drawing.Point(12, 12);
            this.GbxMain.Name = "GbxMain";
            this.GbxMain.Size = new System.Drawing.Size(460, 151);
            this.GbxMain.TabIndex = 0;
            this.GbxMain.TabStop = false;
            this.GbxMain.Text = "컨트롤 학습";
            this.GbxMain.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Nud1
            // 
            this.Nud1.Location = new System.Drawing.Point(66, 60);
            this.Nud1.Name = "Nud1";
            this.Nud1.Size = new System.Drawing.Size(120, 21);
            this.Nud1.TabIndex = 8;
            this.Nud1.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "글자크기";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(6, 97);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(316, 38);
            this.TxtResult.TabIndex = 6;
            this.TxtResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkbold
            // 
            this.chkbold.AutoSize = true;
            this.chkbold.Location = new System.Drawing.Point(201, 19);
            this.chkbold.Name = "chkbold";
            this.chkbold.Size = new System.Drawing.Size(48, 16);
            this.chkbold.TabIndex = 2;
            this.chkbold.Text = "볼드";
            this.chkbold.UseVisualStyleBackColor = true;
            this.chkbold.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "글자체";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkita
            // 
            this.chkita.AutoSize = true;
            this.chkita.Location = new System.Drawing.Point(256, 18);
            this.chkita.Name = "chkita";
            this.chkita.Size = new System.Drawing.Size(60, 16);
            this.chkita.TabIndex = 10;
            this.chkita.Text = "이테릭";
            this.chkita.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 618);
            this.Controls.Add(this.GbxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "속성확인";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbxMain.ResumeLayout(false);
            this.GbxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxMain;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.CheckBox chkbold;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Nud1;
        private System.Windows.Forms.CheckBox chkita;
    }
}

