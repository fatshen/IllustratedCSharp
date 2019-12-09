using System;

namespace PositionalParameters
{
    class MyClass
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public float Avg(float x, float y)
        {
            return (x + y) / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            int SomeInt = 6;

            Console.WriteLine("Sum: {0} and {1} is {2}", 5, SomeInt, mc.Sum(5, SomeInt));
            Console.WriteLine("Avg: {0} and {1} is {2}", 5, SomeInt, mc.Avg(5, SomeInt));
        }
    }
}
