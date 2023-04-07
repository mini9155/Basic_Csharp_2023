using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "abcd" && txtPw.Text == "1234")
            {
                lbres.Text = "로그인 성공";
            }
            else
                lbres.Text = "로그인 실패";
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {


        }
        private void txtPw_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
