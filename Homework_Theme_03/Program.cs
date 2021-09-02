using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя игрока 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Введите имя игрока 2: ");
            string name2 = Console.ReadLine();
            
            Random r = new Random();
            int gameNumber = r.Next(12, 121);
            Console.WriteLine($"Задуманое число: {gameNumber}");
            
            while (gameNumber > 0)
            {
                

                Console.WriteLine($"Ход игрока {name1}. Введите число от 1 до 4: ");
                int ans1 = int.Parse(Console.ReadLine());
                if (ans1 > 0 && ans1 < 5)
                {
                    if (gameNumber - ans1 < 0)
                    { 
                        Console.WriteLine($"На этом ходу вы можете выиграть если введете {gameNumber}.");
                        
                    }
                    else
                    {
                        if ((gameNumber - ans1) == 0)
                        {
                            Console.WriteLine($"Победил игрок - {name1}. Хотите реванш? (Da, Net)");
                            string revansh = Console.ReadLine();
                            if (revansh == "Da")
                            {
                                gameNumber = r.Next(12, 121);
                                Console.WriteLine($"Задуманое число: {gameNumber}");
                                continue;
                            }
                            else
                            {
                                break;
                            }
                            
                        }
                    gameNumber -= ans1;
                    }
                }
                else
                {
                    Console.WriteLine("Не вырне значення!");
                }
                Console.WriteLine($"Осталось - {gameNumber}");

                Console.WriteLine($"Ход игрока {name2}. Введите число от 1 до 4: ");
                int ans2 = int.Parse(Console.ReadLine());
                if (ans2 > 0 && ans2 < 5)
                {
                    if (gameNumber - ans2 < 0)
                    {   
                        Console.WriteLine($"На этом ходу вы можете выиграть если введете {gameNumber}.");
                        
                    }
                    else
                    {
                        if ((gameNumber - ans2) == 0)
                        {
                            Console.WriteLine($"Победил игрок - {name2}. Хотите реванш? (Da, Net)");
                            string revansh = Console.ReadLine();
                            if (revansh == "Da")
                            {
                                gameNumber = r.Next(12, 121);
                                Console.WriteLine($"Задуманое число: {gameNumber}");
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    gameNumber -= ans2;
                    }
                }
                else
                {
                    Console.WriteLine("Не вырне значення!");
                }
                Console.WriteLine($"Осталось - {gameNumber}");
            }
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером
        }
    }
}
