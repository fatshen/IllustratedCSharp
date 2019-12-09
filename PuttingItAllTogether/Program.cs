using System;

namespace PuttingItAllTogether
{
    class DayTemp
    {
        public int Hight;
        public int Low;

        public int Average()
        {
            return (Hight + Low) / 2;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DayTemp t1 = new DayTemp();
            DayTemp t2 = new DayTemp();

            t1.Hight = 76;
            t1.Low = 57;

            t2.Hight = 75;
            t2.Low = 53;

            Console.WriteLine("t1: {0} {1} {2}", t1.Hight, t1.Low, t1.Average());
            Console.WriteLine("t2: {0} {1} {2}", t2.Hight, t2.Low, t2.Average());
        }
    }
}
