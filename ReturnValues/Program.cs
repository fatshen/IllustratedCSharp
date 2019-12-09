using System;

namespace ReturnValues
{
    class MyClass
    {
        public int GetHour()
        {
            DateTime dt = DateTime.Now;
            return dt.Hour;
        }

        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine("Hour: {0}", mc.GetHour());
        }
    }
}
