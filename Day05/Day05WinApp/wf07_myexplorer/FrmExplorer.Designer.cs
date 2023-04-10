namespace wf07_myexplorer
{
    partial class FrmExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExplorer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TrvDrive = new System.Windows.Forms.TreeView();
            this.LblPath = new System.Windows.Forms.Label();
            this.ImgSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.ImgLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.LsvFolder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LblPath);
            this.panel1.Controls.Add(this.TrvDrive);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 501);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.LsvFolder);
            this.panel2.Location = new System.Drawing.Point(328, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 501);
            this.panel2.TabIndex = 0;
            // 
            // TrvDrive
            // 
            this.TrvDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrvDrive.ImageIndex = 0;
            this.TrvDrive.ImageList = this.ImgSmallIcon;
            this.TrvDrive.Location = new System.Drawing.Point(6, 76);
            this.TrvDrive.Name = "TrvDrive";
            this.TrvDrive.SelectedImageIndex = 0;
            this.TrvDrive.Size = new System.Drawing.Size(301, 422);
            this.TrvDrive.TabIndex = 0;
            this.TrvDrive.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.TrvDrive_BeforeCollapse);
            this.TrvDrive.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TrvDrive_BeforeExpand);
            this.TrvDrive.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.TrvDrive_NodeMouseHover);
            this.TrvDrive.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TrvDrive_NodeMouseClick);
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(3, 31);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(41, 14);
            this.LblPath.TabIndex = 1;
            this.LblPath.Text = "label1";
            // 
            // ImgSmallIcon
            // 
            this.ImgSmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgSmallIcon.ImageStream")));
            this.ImgSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgSmallIcon.Images.SetKeyName(0, "hard-drive.png");
            this.ImgSmallIcon.Images.SetKeyName(1, "folder-normal.png");
            this.ImgSmallIcon.Images.SetKeyName(2, "folder-open.png");
            this.ImgSmallIcon.Images.SetKeyName(3, "file-exe.png");
            this.ImgSmallIcon.Images.SetKeyName(4, "file-normal.png");
            // 
            // ImgLargeIcon
            // 
            this.ImgLargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLargeIcon.ImageStream")));
            this.ImgLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLargeIcon.Images.SetKeyName(0, "hard-drive.png");
            this.ImgLargeIcon.Images.SetKeyName(1, "folder-normal.png");
            this.ImgLargeIcon.Images.SetKeyName(2, "folder-open.png");
            this.ImgLargeIcon.Images.SetKeyName(3, "file-exe.png");
            this.ImgLargeIcon.Images.SetKeyName(4, "file-normal.png");
            // 
            // LsvFolder
            // 
            this.LsvFolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvFolder.HideSelection = false;
            this.LsvFolder.Location = new System.Drawing.Point(3, 76);
            this.LsvFolder.Name = "LsvFolder";
            this.LsvFolder.Size = new System.Drawing.Size(454, 422);
            this.LsvFolder.TabIndex = 0;
            this.LsvFolder.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "날짜";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "유형";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "크기";
            // 
            // FrmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmExplorer";
            this.Text = "나의 탐색기 v1.0";
            this.Load += new System.EventHandler(this.FrmExplorer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.TreeView TrvDrive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList ImgSmallIcon;
        private System.Windows.Forms.ImageList ImgLargeIcon;
        private System.Windows.Forms.ListView LsvFolder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

