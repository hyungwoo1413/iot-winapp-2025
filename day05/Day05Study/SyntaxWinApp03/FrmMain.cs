namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "현재상태 : 진행";
            BtnStart.Text = "진행중";
            BtnStart.Enabled = false; // 못쓰게 함

            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;

            await Task.Run(() =>
            {
                for(int i=0; i<MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)((i * 100) / MaxVal) + 1;
                    Console.WriteLine(progress.ToString());

                    this.Invoke(new Action(() => 
                    { 
                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionLength = TxtLog.Text.Length;
                        TxtLog.ScrollToCaret();  // 스크롤을 제일 밑으로
                        PrgProcess.Value = progress;
                    }));
                    //Thread.Sleep(50);
                    //Application.DoEvents();  // 권장X
                }
            });

            LblCurrState.Text = "현재상태 : 중지";
            BtnStart.Text = "시작";
            BtnStart.Enabled = true;
        }
    }
}
