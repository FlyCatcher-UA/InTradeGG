using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_New22_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i <= a; i++)
            {
                for (int j = a; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

            Console.WriteLine();

            for (int i = 0; i <= a; i++)
            {
                for (int j = a; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                
            }
            Console.WriteLine();

            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = a; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
