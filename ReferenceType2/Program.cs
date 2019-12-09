using System;

namespace ReferenceType2
{
    class MyClass
    {
        public int val = 20;
    }

    class Program
    {
        static void MyMethod(ref MyClass f1)
        {
            f1.val = 50;
            Console.WriteLine("f1.val: {0}", f1.val);

            f1 = new MyClass();
            Console.WriteLine("f1.val: {0}", f1.val);
        }

        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine("mc.val: {0}", mc.val);

            MyMethod(ref mc);

            Console.WriteLine("mc.val: {0}", mc.val);
        }
    }
}
