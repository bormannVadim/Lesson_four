using System;
using System.Threading;

namespace Task_one
{
    class Program
    {
        static void Main(string[] args)
        {
            // Савенко В
            int[] arr = new int[20];
            FillArray(arr);

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine((i + 1) + ": " + arr[i]);

            Console.WriteLine("В массиве "+DivideBy3(arr)+" пар, где только одно из двух чисел делится на 3...");
        }

        static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Random r = new Random();
                arr[i] = r.Next(-10000,10000);
                Thread.Sleep(100);
            }
        }

        static int DivideBy3(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] % 3 == 0 && arr[i + 1] % 3 != 0)
                    counter++;
                else if (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0)
                    counter++;
            }
            return counter;
        }
    }
}
