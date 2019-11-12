using System;

namespace FormatField
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 12.3445678;
            Console.WriteLine("{0,-10:G} -- General",                       myDouble);
            Console.WriteLine("{0,-10} -- Default, same as Gernal",         myDouble);
            Console.WriteLine("{0,-10:F4} -- Fixed point, 4 dec places",    myDouble);
            Console.WriteLine("{0,-10:C} -- Currency",                      myDouble);
            Console.WriteLine("{0,-10:E3} -- Sci. Notation, 3dec places",   myDouble);
            Console.WriteLine("{0,-10:x} -- Hexadecimal integer",           1194719);
        }
    }
}
