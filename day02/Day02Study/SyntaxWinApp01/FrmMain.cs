namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // var int09 = 10; // var는 전역변수 사용 불가
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            // 정수 자료형
            sbyte sbtVal = 127;                              // signed byte : -128 ~ 127
            System.SByte sbtVal2 = System.SByte.MinValue;    // -128 할당
            byte btVal = 255;                                // byte : 0 ~ 255 (1 byte)
            System.Byte btVal2 = System.Byte.MinValue;       // 0 할당
            short stVal = 32767;                             // short : -32768 ~ 32767
            System.Int16 stVal2 = System.Int16.MinValue;     // -32768 할당
            ushort ustVal = 65535;                           // unsigned short : 0 ~ 65535 (2 bytes)
            System.UInt16 ustVal2 = System.UInt16.MinValue;  // 0 할당
            int intVal = 2147483647;                         // int : -21억 ~ 21억
            System.Int32 intVal2 = System.Int32.MinValue;    // -21억 할당
            uint uintVal = 4294967295;                       // uint : 0 ~ 42억 (4 bytes)
            System.UInt32 uintVal2 = System.UInt32.MinValue; // 0 할당
            long longVal = 0;                                 // long : -92경 ~ 92경
            ulong ulongVal = 0;                               // unsigned long : 1800경 (8 bytes)
            System.Int64 longVal2;                            // (8 bytes)
            System.Int128 biglongVal2;                        // (16 bytes)

            // 실수 자료형
            float fVal = 3.141592f;                          // float : 4 bytes 소수점
            System.Single fVal2 = System.Single.MinValue;    // +-1.5e-45 할당
            double dVal = 3.141592;                          // double : 8 bytes 소수점
            decimal dcVal = 3.141592m;                       // decimal : 16 bytes 소수점

            // 문자형 타입
            char ch01 = 'A';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);
            System.Char ch03 = 'B';

            string str01 = "Hello\0World!"; // \0 : end of line
            System.String str02 = "Hello C#";

            // 불린 타입
            bool bool01 = true;
            System.Boolean bool02 = false;

            // Nullable
            // int int02 = null;   // 기본타입(정수형, 실수형, 불린 / 문자열 제외)은 NULL 할당불가
            int? int03 = null;  // 기본타입 뒤에 ? 붙여줄 것

            const int int04 = 15;   // const를 만나면 상수. 한번 할당 후 변경 불가
            // int04 = 26;

            // 동적타입 // 컴파일 되면서 해당 타입으로 자료형 결정
            var int05 = 50;

            //MessageBox.Show(intVal2.ToString() + ch01 + ch02, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(int03.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
