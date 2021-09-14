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
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            while (num1 <= num2)
            {
                if ((num1 % 2) == 0)
                {
                    counter++;
                }
                num1++;
            }
            Console.WriteLine($"{counter} - значень кратних 2.");
            Console.ReadKey();
        }
    }
}
