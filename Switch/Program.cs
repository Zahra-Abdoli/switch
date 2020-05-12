using System;
using System.Runtime.InteropServices;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please inter numerical mark:");
                int mark = Convert.ToInt32(Console.ReadLine());
                Print(mark);
            }
        }
        static void Print(int mark)
        {

            if (10>= mark && mark >= 9) Console.WriteLine("Excellent");
            else if (8 >= mark && mark >= 7) Console.WriteLine("Notable");
            else if (mark == 6) Console.WriteLine("Good");
            else if (mark == 5) Console.WriteLine("Pass");
            else Console.WriteLine("Fail");



        }
    }
}
