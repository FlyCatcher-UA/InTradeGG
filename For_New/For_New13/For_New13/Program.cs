using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_New13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Num 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("+, -, *, /, ");
            string x = Console.ReadLine();

            switch (x)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    if (b==0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                    break;
                default:
                    break;
            }

            //Console.WriteLine("Num 1: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Num 2: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("+, -, *, /, ");
            //string x = Console.ReadLine();
            //if (x == "+")
            //{
            //    Console.WriteLine(a+b);
            //}
            //if (x == "-")
            //{
            //    Console.WriteLine(a - b);
            //}
            //if (x == "*")
            //{
            //    Console.WriteLine(a * b);
            //}
            //if (x == "/")
            //{
            //    Console.WriteLine(a / b);
            //}
            Console.ReadKey();



        }
    }
}
