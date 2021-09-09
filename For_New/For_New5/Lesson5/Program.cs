using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест ТрайПарс. Введите число: ");
            string str2 = Console.ReadLine();
            int x;
            int.TryParse(str2, out x);
            Console.WriteLine($"x = {x}");

            try
            {
                Console.Write("Введите число 1: ");
                string str = Console.ReadLine();
                int a = Convert.ToInt32(str);
                int c = int.Parse(str);
                
                Console.Write("Введите число 2: ");
                str = Console.ReadLine();
                int b = Convert.ToInt32(str);
                int d = int.Parse(str);
                Console.WriteLine("Good Convertation");
                Console.WriteLine($"Сумма = {a+b}; {c+d}");
            }
            catch (Exception)
            {
                Console.WriteLine("Error Convertation");
            }

            Console.ReadKey();

        }
    }
}
