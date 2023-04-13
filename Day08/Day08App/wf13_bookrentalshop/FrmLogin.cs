using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmLogin : Form
    {
        private bool isLogined = false; // 로그인이 성공 했는지 변수
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            isLogined = LoginProcess();

            if (isLogined)
            {
                this.Close();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // 가장 완벽하게 프로그램 종료
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e) //  폼이 닫힐 때 이벤트
        {
            if (isLogined != true)
            {
                Environment.Exit(0);
            }
        }

        private void Txtpwd_Click(object sender, EventArgs e)
        {

        }

        #region<id,pw 키를 눌렀을 때)
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtpw.Focus();
            }
        }
        private void txtpw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e); // 버튼 클릭 후 이벤트 핸들러 호출
            }

        }
        #endregion


        #region<txt에 아무것도 없을 때>
        private bool LoginProcess()
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("유저 아이디를 입력하세요!!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtpw.Text))
            {
                MessageBox.Show("비밀번호를 입력하세요!!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string strUserId = txtid.Text;
            string strpassword = txtpw.Text;

            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=12345";
                //DB 처리
                //MySqlConnection conn = new MySqlConnection(connectionString);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {

                    conn.Open();
                    string selQuery = @"SELECT userid
                                            ,password
                                        FROM usertbl
                                        WHERE userid = @userid
                                        AND password = @password";

                    MySqlCommand selCmd = new MySqlCommand(selQuery, conn);
                    MySqlParameter prmUserId = new MySqlParameter("@userid", txtid.Text);
                    MySqlParameter prmpw = new MySqlParameter("@password", txtpw.Text);
                    selCmd.Parameters.Add(prmUserId);
                    selCmd.Parameters.Add(prmpw);

                    MySqlDataReader reader = selCmd.ExecuteReader();
                    if (reader.Read())
                    {

                        strUserId = reader["userId"] != null ? reader["userId"].ToString() : "-";
                        strpassword = reader["password"] != null ? reader["password"].ToString() : "--";
                        MessageBox.Show($"{strUserId}님 환영합니다!! ");

                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"로그인정보가 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
        #endregion

    }
}
