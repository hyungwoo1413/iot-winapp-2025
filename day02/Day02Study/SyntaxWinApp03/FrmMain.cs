namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // 분기문
            if (TxtPain.Text == "아니오")
            {
                MessageBox.Show("집에 가라", "아픈 데 없으면", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPain.Text == "네")
            {
                string PainPoint = CboPainPoint.SelectedItem.ToString();

                // switch 문
                switch (PainPoint)
                {

                    // 머리 눈 코 목 가슴 배

                    case "머리":
                        MessageBox.Show("신경과로 가세요", "진료과 선택");
                        break;
                    case "눈":
                        MessageBox.Show("안과로 가세요", "진료과 선택");
                        break;
                    case "코":
                        MessageBox.Show("이비인후과로 가세요", "진료과 선택");
                        break;
                    case "목":
                        MessageBox.Show("이비인후과로 가세요", "진료과 선택");
                        break;
                    case "가슴":
                        MessageBox.Show("내과로 가세요", "진료과 선택");
                        break;
                    case "배":
                        MessageBox.Show("소화과로 가세요", "진료과 선택");
                        break;
                }
            }
            else
            {
                MessageBox.Show("'네' 또는 '아니오'로 입력하세요", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 키프레스에서 엔터를 입력하면 (C, C++ if문과 동일)
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(TxtPain.Text, "입력값");
            }
        }

        private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPoint = CboPainPoint.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "통증부위");
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            TxtResult.Text = string.Empty; // 초기화
            // for문
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    TxtResult.Text += i + "x" + j + "=" + i * j + "\t";
                }
                TxtResult.Text += "\r\n";
            }
        }

        int clickNum = 0;

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            // 반복
            while (clickNum < 10)
            {
                MessageBox.Show("계속 " + clickNum);
                clickNum++;
            }
            clickNum = 0;
        }
    }
}
