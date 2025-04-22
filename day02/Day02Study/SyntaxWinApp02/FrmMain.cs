namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // 연산자 : =, +, -, *, /, %, +=, -=, *=
            // &&, ||, &, |, ^, !
            // C, C++ 와 동일
            int val = (int)Math.Pow(2, 10);

            //MessageBox.Show(((3 > 2) && (10 < 9)).ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(val.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
