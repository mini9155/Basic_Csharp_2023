using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace wf14_winforms_thread
{
    public partial class FrmMain : Form
    {
        int number = 0;
        int percent;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Worker.WorkerSupportsCancellation = true;
            Worker.WorkerReportsProgress = true;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker; // 인자값으로 생성
            e.Result = Fibonacci((int)e.Argument, worker, e);
        }

        private long Fibonacci(int arg, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (arg < 0 || arg > 91)
            {
                throw new Exception("오류 0 ~ 91 사이 입력");
            }

            long result = 0;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
            }
            else
            {
                if (arg < 2)
                {
                    result = 1;
                }
                else
                {
                    result = Fibonacci(arg - 1, worker, e) + Fibonacci(arg - 2, worker, e);
                }

                // 진행사항을 프로그래스바에 표시
                int percentComplete = (int)(arg / number * 100);
                if (percentComplete > percent)
                {
                    percent = percentComplete;
                    Worker.ReportProgress(percentComplete);
                }
            }
            return result;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if(e.Cancelled)
            {
                Lblres.Text = "취소됨";
            }
            else
            {
                Lblres.Text = e.Result.ToString();
            }

            TxtNumber.Text = 0.ToString();
            BtnStart.Enabled = true;
            BtnCancle.Enabled = false;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PgbCalc.Value = e.ProgressPercentage; // 진행사항 표시
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = false; // 시작버튼은 종료시 까지 누르지 못함
            BtnCancle.Enabled = true;

            number = int.Parse(TxtNumber.Text);

            percent = 0;
            PgbCalc.Value = percent;
            Worker.RunWorkerAsync(number); // 비동기로 진행
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            // Button button = sender as Button
            Worker.CancelAsync(); // 비동기로 취소 시키라고 요청
            BtnCancle.Enabled = false; // 시작 버튼은 종료시 까지 누르지 못함
            BtnStart.Enabled = true;
        }
    }
}
