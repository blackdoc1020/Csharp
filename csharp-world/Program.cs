using System;

namespace StudyClass
{
    class Person // class 클래스를 만드는 키워드 // Person: 클래스로 만들어진 새로운 데이터 타입
    {
        public int age; //클래스 내부의 멤버 필드
        public long height; //클래스 내부의 멤버 필드
        public float weight; //클래스 내부의 멤버 필드 
    } // class
    public class Top
    {
        public int a;
        public int b;
        public int GetData()
        {
            return a + b;
        }
    }// class


    class Program
    {
        static void Main(string[] args)
        {
            Person sister = new Person(); // 객체 생성, 변수 생성
            sister.age = 100;
            sister.height = 170L;
            sister.weight = 67.0F;
            Console.WriteLine("age : {0}", sister.age);
            Console.WriteLine("height : {0}", sister.height);
            Console.WriteLine("weight : {0}", sister.weight);

            Top t = new Top();
            t.a = 100;
            t.b = 200;
            int c1 = t.GetData();

            Top s = new Top();
            s.a = 1000;
            s.b = 2000;
            int c2 = s.GetData();

            Console.WriteLine("t.a는 {0}, t.b는 {1}, t.GetData()는 {2}", t.a, t.b, c1);
            Console.WriteLine("s.a는 {0}, s.b는 {1}, s.GetData()는 {2}", s.a, s.b, c2);
        }
    }
}
