using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try {
                    Console.WriteLine("please inter numerical mark:");
                    int mark = Convert.ToInt32(Console.ReadLine());
                    PrintFor(mark);
                }
                catch { Console.WriteLine("type should be number"); }
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
        static void PrintFor (int mark)
        {
            switch (mark)
            {
                case 10:
                    Console.WriteLine("Excellent");
                    break;
                case 9:
                    Console.WriteLine("Excellent");
                    break;
                case 8:
                    Console.WriteLine("Notable");
                    break;
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("pass");
                    break;
                default:
                    Console.WriteLine("Faild") ;
                    break;
            }

        } 
    }
}
