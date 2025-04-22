namespace SyntaxWinApp01
{
    internal class Person
    {
        public Person()
        {

        }

        public Person(string name, int age, char gender, string phone)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Phone = phone;
        }

        public string Name { get; set; }  // getName, setName을 자동 생성
        // Age가 int이기 때문에 -21억 ~ 21억
        // 그냥 값을 받고 사용할 때는 public int Age { get; set; } 사용
        // 0~200 사이만 들어가도록 변경
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 200)  // value -> 특수 키워드, 할당되는 값을 뜻함
                {
                    value = 20;  // 잘못 넣으면 디폴트 20으로 저장
                }
                age = value;
            }
        }
        public char Gender { get; set; }
        public string Phone { get; set; }

        public override string ToString()  // Python 클래스 __str__() 와 동일
        {
            return // $"Person 객체\r\n" + 
                   $"이름: {Name}\r\n" +
                   $"나이: {Age}세\r\n" +
                   $"성별: {Gender}\r\n" +
                   $"핸드폰: {Phone}\r\n";
        }
        public void GetUp()
        {
            MessageBox.Show($"{Name}가 아침에 일어납니다.");
        }

        public void GoToSchool()
        {
            MessageBox.Show($"{Name}가 학교에 갑니다.");
        }

        public static int GetNumber()
        {
            return 20;
        }
    }
}
