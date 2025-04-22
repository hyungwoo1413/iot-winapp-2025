namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "";
            try
            {
                Person p = new Person();
                p.Name = TxtName.Text.Trim();
                p.Age = int.Parse(TxtAge.Text.Trim());
                p.Gender = char.Parse(TxtGender.Text.Trim());
                p.Phone = TxtPhone.Text.Trim();

                TxtResult.Text += p.ToString();
                p.GetUp();
                p.GoToSchool();

                // static : 컴파일 후 실행되면 메모리에 자리를 잡음
                // 객체를 생성하지 않고 바로 쓸 수 있음
                // static 변수, 다른 static 메서드만 사용 가능
                Person.GetNumber();
            }
            catch
            {
                MessageBox.Show("정보를 확인하세요.");
            }
        }
    }
}
