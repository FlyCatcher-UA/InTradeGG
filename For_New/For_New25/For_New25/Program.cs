using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_New25
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Enumerable.Repeat(1, 5).ToArray();
            //int[] arr2 = Enumerable.Range(3, 5).ToArray();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i]);
            //}
            //Console.ReadKey();
            int sums = 0;
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                if (arr[i] % 2 == 0)
                {
                    sums = sums + arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(arr.Min());
            Console.WriteLine(sums);
            Console.ReadKey();
        }
    }
}
