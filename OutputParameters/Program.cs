using System;

namespace OutputParameters
{
    class MyClass
    {
        public int val = 20;
    }

    class Program
    {
        static void MyMethod(out MyClass f1, out int f2)
        {
            f1 = new MyClass();
            f1.val = 50;
            f2 = 15;
        }

        static void Main(string[] args)
        {
            MyClass a1 = null;
            int a2;

            MyMethod(out a1, out a2);
            Console.WriteLine("a1.val: {0}, a2: {1}", a1.val, a2);
        }
    }
}
