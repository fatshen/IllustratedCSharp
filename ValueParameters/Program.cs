using System;

namespace ValueParameters
{
    class MyClass
    {
        public int val = 20;
    }

    class Program
    {
        static void MyMethod(MyClass f1, int f2)
        {
            f1.val = f1.val + 5;
            f2 = f2 + 5;
            Console.WriteLine("f1.val: {0}, f2: {1}", f1.val, f2);
        }

        static void Main(string[] args)
        {
            MyClass a1 = new MyClass();
            int a2 = 10;
            Console.WriteLine("f1.val: {0}, f2: {1}", a1.val, a2);
            MyMethod(a1, a2);
            Console.WriteLine("f1.val: {0}, f2: {1}", a1.val, a2);
        }
    }
}
