using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf12_notepad
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                txtpath.Text = fileName;

                FileStream stream = null;
                StreamReader reader = null;

                try
                {
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream, Encoding.UTF8);

                    RtbEditor.Text = reader.ReadToEnd();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"오류!{ex.Message}","심플메모장",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    reader.Close();
                    stream.Close();
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = txtpath.Text;

            FileStream stream = null;
            StreamWriter Writer = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                Writer = new StreamWriter(stream, Encoding.UTF8);
                Writer.WriteLine(RtbEditor.Text); // 리처텍스트 박스 내용을 씀
                Writer.Flush(); // 버퍼의 데이터를 해당 스트림에 전송

                MessageBox.Show("저장되었습니다!!", "심플메모장", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류!{ex.Message}", "심플메모장", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Writer.Close();
                stream.Close();
            }
        }
    }
}
