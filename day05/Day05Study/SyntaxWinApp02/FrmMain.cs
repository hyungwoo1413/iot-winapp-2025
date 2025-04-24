namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int add(int x, int y)
        {
            return x + y;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            // 대리자 = 람다식
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 6) + "\r\n";

            // SayHello 함수 생성 대신 람다식 사용
            Action<string> SayHello = name => MessageBox.Show($"안녕, {name}!", "인사", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            SayHello("형우");

            // LINQ 사용 이전
            List<int> resList = new List<int>();
            List<int> numbers = [6, 3, 1, 10, 7, 5, 8, 4, 2, 9];
            List<string> words = ["Hello", "World"];

            // 짝수만 추출해서 오름차순 정렬하는 로직
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    resList.Add(n);
                }
            }
            TxtLog.Text += $"짝수 리스트: {string.Join(" ", resList)}\r\n";
            resList.Sort();
            TxtLog.Text += $"정렬 리스트: {string.Join(" ", resList)}\r\n";

            // 기본 LINQ 방식 (위의 방식을 3줄로 처리 가능)
            numbers = [17, 11, 16, 20, 19, 13, 15, 12, 18, 14];
            var resList2 = from n in numbers
                           where n % 2 == 0
                           orderby n
                           select n;
            TxtLog.Text += $"링큐1 정렬 리스트: {string.Join(" ", resList2)}\r\n";

            // LINQ Method Chaining
            numbers = [24, 30, 21, 25, 28, 26, 29, 23, 27, 22];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += $"링큐2 정렬 리스트: {string.Join(" ", resList3)}\r\n";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // UI 초기화
            TxtTest.PlaceholderText = "테스트입니다";
            TxtTest.Size = new Size(200, 23);
            // TxtTest.KeyPress += TxtTest_KeyPress;  // Designer에서 작업하는 것과 동일
            TxtTest.Font = new Font("휴먼매직체", 12, FontStyle.Italic);
        }

        private void TxtTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("엔터를 클릭했습니다.", "키프레스", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            // 제네릭 기본
            Print<int>(100);
            Print<float>(3.141592f);
            Print<string>("안녕, 형우!");
            Print<bool>(false);

            // 생략가능(편의성을 위해서)
            Print(100);
            Print(3.141592f);
            Print("안녕, 형우!");
            Print(false);

            // 제네릭 클래스 사용
            Box<int> intBox = new Box<int>();
            intBox.Value = 300;
            intBox.Show();

            Box<string> strBox = new Box<string>();
            strBox.Value = "삼백";
            strBox.Show();
        }

        public void Print<T>(T data) { Console.WriteLine(data); }
    }

    public class Box<T>
    {
        public T Value { get; set; }  // 속성
        // private T Value;  // 멤버변수

        public void Show()
        {
            MessageBox.Show($"Box의 값 : {Value}", "Box 값", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
