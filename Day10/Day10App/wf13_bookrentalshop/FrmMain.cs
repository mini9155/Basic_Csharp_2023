using System;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmMain : Form
    {
        FrmGenre frmGenre = null; // 책장르관리 객체변수
        FrmBooks frmBooks = null; // 책 정보 관리
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();

            frm.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MniInfo_Click(object sender, EventArgs e)
        {

        }

        private void MniRental_Click(object sender, EventArgs e)
        {

        }

        private void Mni1_Click(object sender, EventArgs e)
        {

        }

        private void MniGenre_Click(object sender, EventArgs e)
        {
            //FrmGenre frm = new FrmGenre();
            //frm.StartPosition = FormStartPosition.CenterParent;
            //frm.TopLevel = false;
            //this.Controls.Add(frm);
            //frm.Show();
            frmGenre = ShowActiveForm(frmGenre, typeof(FrmGenre)) as FrmGenre;
        }


        private Form ShowActiveForm(Form form, Type type)
        {
            if (form == null) // 한번도 창을 안 열었으면
            {
                form = (Form)Activator.CreateInstance(type); //리플렉션으로 타입에 맞는 창을 새로 생성
                form.MdiParent = this; //FrmMain이 MDI 부모
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)// 한 번 닫혔으면
                {
                    form = (Form)Activator.CreateInstance(type); //리플렉션으로 타입에 맞는 창을 새로 생성
                    form.MdiParent = this; //FrmMain이 MDI 부모
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else
                {
                    form.Activate();
                }
            }

            return form;
        }

        private void MniBookInfo_Click(object sender, EventArgs e)
        {

                frmBooks = ShowActiveForm(frmBooks, typeof(FrmBooks)) as FrmBooks;
        }
    }
}
