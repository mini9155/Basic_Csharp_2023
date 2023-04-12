using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf11_mdietest
{
    public partial class FrmMain : Form
    {
        FrmChild1 child1 = null;
        Frmchild2 child2 = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        [Obsolete("OldMethod는 다음 버전에서 페기됩니다.NewMethod를 이용하세요.")]
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MiniForm1_Click(object sender, EventArgs e)
        {
            OldMethod();
            child1 = new FrmChild1();
            child1.TopLevel = false;
            this.Controls.Add(child1);
            child1.Show();
        }

        private void OldMethod()
        {
            Console.WriteLine("올드 메서드");
        }
        private void MiniForm2_Click(object sender, EventArgs e)
        {

        }

        private void MniExit_Click(object sender, EventArgs e)
        {

        }

        private void MniAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }
    }
}
