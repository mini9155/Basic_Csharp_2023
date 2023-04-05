using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf03_propoty
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {

            InitializeComponent(); // 절대 건들 ㄴㄴ
            //생성자에는 되도록 설정부분을 넣지마세요.
            //Form_Load()이벤트 헨들러에 작성할 것
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GbxMain.Text = "그룹박스"; // 그룹박스 이름 설정
            var fonts = FontFamily.Families.ToList(); // 내 OS 폰트이름 가져오기
            foreach(var font in fonts)
            {
                comboBox1.Items.Add(font.Name);
            }
            // 글자크기 최소값 최대값 지정
            Nud1.Minimum = 5; Nud1.Maximum = 40;

            //텍스트박스 초기화
            TxtResult.Text = "Hello,world";
            Nud1.Value = 9;

        }

        private void ChangeFontStyle()
        {
            if (comboBox1.SelectedIndex < 10) return;

            FontStyle style = FontStyle.Regular;
            if (chkbold.Checked == true)
            {
                style |= FontStyle.Bold;
            }
            if (chkita.Checked == true)
            {
                style |= FontStyle.Italic;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
