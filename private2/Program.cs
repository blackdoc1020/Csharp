//은폐화(Encapsulation)를 테스트하는 클래스
using System;

namespace private2
{
    public class MeanCalc
    {
        private int sum; // 합을 저장하기 위한 private 멤버
        private int num; // 값의 개수를 저장하기 위한 private 멤버

        //외부로 부터 들어온 값을 가공하는 public 멤버 메서드
        public void SetValue(int w, int x, int y, int z, int n)
        {
            sum = w + x + y + z;
            num = n;
        }

        public int GetValue()
        {
            return sum / num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MeanCalc m = new MeanCalc(); //객체 생성
            m.SetValue(3, 5, 120, 40, 4); //private 멤버에 가공해서 값 할당
            int s = m.GetValue(); // private 멤버의 가공된 값 얻기
            Console.WriteLine("평균 = {0}{1}", s); //데이터 출력


        }
    }
}
