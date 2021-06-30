//속성를 테스트하는 예제
using System;

namespace Property
{
    class PropTest
    {
        private string name; //소문자 이름
        public string Name //대문자 이름
        {
            get
            {
                return name;
            }
            set
            {
                name = value + "님 반갑습니다.";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PropTest p = new PropTest();
            p.Name = "홍길동";
            string a = p.Name;
            Console.WriteLine("이름: {0}", a);
        }
    }
}
