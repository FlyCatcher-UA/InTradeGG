using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New16
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int sums = 0;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = 0;
            if (num1>num2)
            {
                num3 = num2;
                num2 = num1;
                num1 = num3;
            }
            while (num1 <= num2)
            {
                if ((num1 % 2) == 0)
                {
                    counter++;
                    sums = sums + num1;
                }
                num1++;
            }
            Console.WriteLine($"{counter} - количество четных.");
            Console.WriteLine($"{sums} - сума четных.");
            Console.ReadKey();
        }
    }
}
