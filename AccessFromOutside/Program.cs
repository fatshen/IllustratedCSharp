using System;

class DayTemp
{
    public int High = 75;
    public int Low = 45;
}

namespace AccessFromOutside
{
    class Program
    {
        static void Main(string[] args)
        {
            DayTemp temp = new DayTemp();

            temp.High = 80;
            temp.Low = 40;

            Console.WriteLine("High:    {0}", temp.High);
            Console.WriteLine("Low:     {0}", temp.Low);
        }
    }
}
