using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmGenre : Form
    {
        bool isNew = false;

        public FrmGenre()
        {
            InitializeComponent();
        }

        private void FrmGenre_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void RefreshData()
        {
            //DB divtbl 데이터 조회
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var selQeury = @"SELECT Division
                                    ,Names
                                    FROM divtbl;";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selQeury, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "divtbl");

                    //Dgvres.DataSource = ds;
                    //Dgvres.DataMember = "divtbl";

                    Dgvres.DataSource = ds.Tables[0];

                    Dgvres.Columns[0].HeaderText = "장르코드";
                    Dgvres.Columns[1].HeaderText = "장르명";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtCode.ReadOnly = false; // 수정 금지
            TxtName.ReadOnly = false; // 수정 금지
            ClearInputs();
        }

        private void ClearInputs()
        {
            TxtCode.Text = TxtName.Text = string.Empty;
            TxtCode.Focus();
            isNew = true;
        }

        private void SaveData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) { conn.Open(); }

                    var query = "";

                    if (isNew)
                    {
                        query = @"INSERT INTO divtbl
                                    VALUES
                                    ( @Division
                                    , @Names )";

                    }
                    else
                    {
                        query = @"UPDATE divtbl
                                    SET Names = @Names
                                    WHERE Division = @Division;";

                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlParameter prmDivision = new MySqlParameter("@Division", TxtCode.Text);
                    MySqlParameter prmNames = new MySqlParameter("@Names", TxtName.Text);
                    cmd.Parameters.Add(prmDivision);
                    cmd.Parameters.Add(prmNames);

                    var result = cmd.ExecuteNonQuery();

                    if (result != 0)
                    {
                        MessageBox.Show("저장 성공", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("저장 실패", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation() != true) { return; }

            SaveData();
            RefreshData();
            ClearInputs();
        }

        // 입력 검증
        private bool CheckValidation()
        {
            var result = true;
            var errormsg = string.Empty;

            if (string.IsNullOrEmpty(TxtCode.Text))
            {
                result = false;
                errormsg += "장르코드을 입력하세요.\r\n";
                //입력 검증
            }
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                result = false;
                errormsg += "장르명을 입력하세요.\r\n";
                //입력 검증
            }

            if (result == false)
            {
                MessageBox.Show(errormsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            else
            {
                return result;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (isNew == true)
            {
                MessageBox.Show("삭제할 데이터를 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(this, "삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                                    DialogResult.No) return;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) { conn.Open(); }

                    var query = "";

                    query = @"DELETE FROM divtbl
                              WHERE Division = @Division";


                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlParameter prmDivision = new MySqlParameter("@Division", TxtCode.Text);
                    cmd.Parameters.Add(prmDivision);

                    var result = cmd.ExecuteNonQuery();

                    if (result != 0)
                    {
                        MessageBox.Show("삭제 성공", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshData();
            ClearInputs();
        }

        private void Dgvres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var selData = Dgvres.Rows[e.RowIndex];
                //MessageBox.Show(selData.ToString());

                // Debug.WriteLine(selData.ToString());
                Debug.Write(selData.Cells[0].Value);
                Debug.Write(selData.Cells[1].Value);
                TxtCode.Text = selData.Cells[0].Value.ToString(); // 텍스트창에 결과 값 출력
                TxtName.Text = selData.Cells[1].Value.ToString();
                TxtCode.ReadOnly = true; // 수정 금지
                TxtName.ReadOnly = true; // 수정 금지
            }
        }
    }
}
