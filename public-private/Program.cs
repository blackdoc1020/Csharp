using System;

namespace public_private
{
    public class TopSecret
    {
        private int secret; // private 멤버 변수 선언

        //private 멤버에 값 할당하기
        public void SetSecret(int x)
        {// private에 접근하는 public 멤버 함수
            secret = x;
        }

        // private 멤버의 값을 외부로 내보내기
        public int GetSecret()
        { // private에 접근하는 public 멤버 함수
            return secret;
        }
    }

    class Person
    {
        public int age; // public 멤버 변수
        public float height; // public 멤버 변수;
        private float weight; // private 멤버 변수;
    }
    class Program
    {
        static void Main(string[] args)
        {
            TopSecret t = new TopSecret();
            t.SetSecret(1000); //멤버 변수에 값을 할당하는 함수
            int s = t.GetSecret();
            Console.WriteLine("secret={0}", s);


            //Person person = new Person();
            //person.age = 100;
            //person.height = 175.0F;
            //person.weight = 65.0F;

            //Console.WriteLine("Age:" + person.age);
            //Console.WriteLine("Height:" + person.height);
            //Console.WriteLine("Weight:" + person.weight);
        }
    }
}
