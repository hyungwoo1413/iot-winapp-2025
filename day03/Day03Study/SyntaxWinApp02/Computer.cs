// using... 네임스페이스 추가
// C,C++의 #include, Python의 import와 동일

using System;
using System.Collections.Generic;
using System.Diagnostics;  // 진단 네임스페이스 Debug 클래스 포함
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxWinApp02
{
    internal class MobileDevice
    {
        public MobileDevice() { }
    }

    internal class Computer
    {
        public Computer()
        {
            // Debug.WriteLine("[디버그] Computer 객체 생성");
            Console.WriteLine("Computer 객체 생성");
        }

        bool powerOn;
        public void Boot() { }
        public virtual void ShutDown()
        {
            Console.WriteLine("컴퓨터 셧다운!");
        }
        public void Reset() { }
    }

    // C++에서는 다중상속이 가능
    // Java, C#은 다중상속을 막음
    internal class Notebook : Computer, IMobile
    {
        public void Call()
        {
            Console.WriteLine("");
        }

        public string GetList()
        {
            string phoneList = "010-1234-1234";
            return phoneList;
        }

        public Notebook()
        {
            Console.WriteLine("Notebook 객체 생성");
            base.Boot();  // 부모클래스의 Boot() 메서드 실행
        }

        // 부모클래스의 ShutDown을 자식에서 다시 재정의
        public override void ShutDown()
        {
            Console.WriteLine("노트북 닫기!");
        }

        bool fingerScan;  // 지문인식

        public bool HasFingerScanDevice() { return this.fingerScan; }
        public bool HasFingerScanDevice(bool fingerScan)
        {
            this.fingerScan = fingerScan;
            Console.WriteLine();
            return this.fingerScan;
        }

    }

    internal class Server : Computer
    {
        public string Name { get; set; }  // 이름 속성 추가

        public Server()
        {
            Console.WriteLine("Server 객체 생성");
        }

        bool storage;  // 스토리지
        public bool HasStorage() { return this.storage; }

        // 깊은 복사 메서드
        public Server DeepCopy()
        {
            return new Server { Name = this.Name };
        }
    }
}
