using System;
using System.Data;
using System.Data.SqlClient; //sql sever용 DB 연결 클라이언트 네임스페이스
using System.Windows.Forms;

namespace wf09_dbhandling
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'northwindDataSet1.Employees' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.employeesTableAdapter.Fill(this.northwindDataSet1.Employees);

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            // 1. 연결 문자열 생성 - 데이터 연결 밑 컴퓨터 이름에 속성에 연결 문자열
            string connectionString = "Data Source=localhost;Initial Catalog=Northwind;User ID=sa;Password=12345";
            // 2. DB연결을 위해서 Connection객체를 생성
            SqlConnection conn = new SqlConnection(connectionString); // 연결 문자열 없이 객체 생성 x // 첫번째 방법


            // 3. 객체를 통해서 DB 연결
            conn.Open();

            //4. DB처리를 위한 쿼리 작성
            // crtl + z 줄 띄움, 앞에 @를 붙이면 정리가 잘 된다
            // 5. sql 데이터 생성
            string selQuery = @"SELECT CustomerID
                                      ,CompanyName
                                      ,ContactName
                                      ,ContactTitle
                                      ,Address
                                      ,City
                                      ,Region
                                      ,PostalCode
                                      ,Country
                                      ,Phone
                                      ,Fax
                                  FROM Customers";
            //SqlCommand selCmd = new SqlCommand(selQuery,conn);
            // selCmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(selQuery,conn);

            // 5. 리더 객체 생성, 값을 넘겨줌

            //패스 리더객체 생성 값을 넘겨줌
            // SqlDataReader reader = selCmd.ExecuteReader();
            
            // 6. 데이터 셋으로 전달
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            // 7. 데이터그리드뷰에 바인딩하기 위한 BIndingSource 생성
            BindingSource source = new BindingSource();

            // 7. 데이터그리드뷰의 DataSource에 데이터셋을 할당
            source.DataSource = ds.Tables[0];
            DgvNorthwind.DataSource = source;

            //8. DB close
            conn.Close();
        }
    }
}
