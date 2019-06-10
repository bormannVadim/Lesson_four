using System;
using System.Threading;

namespace Task_one
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            FillArray(arr);

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine((i + 1) + ": " + arr[i]);

        }

        static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Random r = new Random();
                arr[i] = r.Next(100);
                Thread.Sleep(10);
            }
        }
    }
}
