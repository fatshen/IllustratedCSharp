using System;

namespace MethodInvocations
{
    class MyClass
    {
        void PrintDateAndTime()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0}", dt);
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.PrintDateAndTime();
        }
    }
}
