using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_New22
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                a++;
            }
            Console.WriteLine();
            int b = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 11; j > b; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                b++;
            }
            Console.ReadKey();
        }
    }
}
