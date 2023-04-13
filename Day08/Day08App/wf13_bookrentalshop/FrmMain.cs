using System;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmMain : Form
    {
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
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            FrmGenre frm = new FrmGenre();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.Show();
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
    }
}
