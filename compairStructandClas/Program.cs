//구조체를 테스트하는 예제
using System;

namespace compairStructandClas
{
    struct Person
    {
        public int age;
        public long height;
        public float weight;

        public Person(int a, long h, float w)
        {
            age = a;
            height = h;
            weight = w;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person sister;
            sister.age = 13;
            sister.height = 170L;
            sister.weight = 55f;
            Console.WriteLine("sister : {0}-{1}-{2}", sister.age, sister.height, sister.weight);

            Person brother = new Person();
            Console.WriteLine("brother : {0}-{1}-{2}", brother.age, brother.height, brother.weight);
            Person mother = new Person(40, 160L, 60F);
            Console.WriteLine("mother : {0}-{1}-{2}", mother.age, mother.height, mother.weight);

            Person twins = sister; //값복사
            Console.WriteLine("twins : {0}-{1}-{2}", twins.age, twins.height, twins.weight);          
        }
    }
}
