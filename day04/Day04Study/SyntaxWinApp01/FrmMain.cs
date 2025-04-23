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
            Person person = new Person();

            try
            {
                person.Name = TxtName.Text.Trim();
                // int -> 4bytes 정수, decimal -> 16bytes 실수
                // 큰 사이즈의 데이터형에 작은 사이즈 데이터형 값을 할당(묵시적으로 형변환)
                person.Age = Convert.ToInt32(NudAge.Value);
                person.Gender = Convert.ToChar(TxtGender.Text.Trim());
                person.Phone = TxtPhone.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("성별은 M/F 한글자만 입력하세요.", "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*
            try
            {
                float rval = 0f;
                int x = 10, y = 0;
                rval = x / y;

                MessageBox.Show(rval.ToString());
            }
            catch (ArithmeticException ex) //DivideByZeroException 의 부모 클래스를 사용해도 무방
            {
                //MessageBox.Show(ec.Message, "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("수는 0으로 나눌 수 없습니다.", "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("알 수 없는 예외입니다.", "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                // 예외와 관계없이 항상 실행되어야 하는 구문 여기에 작성.
            }
            */

            // 들어온 Person 객체 값으로 처리
            person.BirthYear = DateTime.Now.Year - person.Age;

            char korGender = person.Gender == 'M' ? '남' : '여';
            string result = $"현재 Person은 {person.Name}\r\n" +
                            $"나이, {person.Age}세({person.BirthYear}년생)\r\n" +
                            $"성별, {korGender}자\r\n" +
                            $"폰번호, {person.Phone}";

            TxtResult.Text = result;
        }
    }
}
