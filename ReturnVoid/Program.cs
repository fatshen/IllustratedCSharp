using System;

namespace ReturnVoid
{
    class MyClass
    {
        void TimeUpdate()
        {
            DateTime dt = DateTime.Now;
            if (dt.Hour < 12)
            {
                return;
            }

            Console.WriteLine("It's afternoon!");
        }

        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.TimeUpdate();
        }
    }
}
