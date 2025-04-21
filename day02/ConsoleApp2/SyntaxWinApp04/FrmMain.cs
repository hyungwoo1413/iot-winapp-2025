namespace SyntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("값을 입력하세요.");
                return; // 메서드 탈출
            }
            else
            {
                // 위의 문제가 없을때 동작...
                LblResult.Text = "처리결과: ";
                TxtResult.Text = "이름: " + TxtName.Text + ", 나이: " + TxtAge.Text + " 성별: " + (RdoMale.Checked ? "남성" : "여성");
            }
        }
    }
}
