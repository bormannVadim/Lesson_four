using System;
using System.Threading;
using System.IO;

namespace task_two
{
    class Program
    {

        static void Main(string[] args)
        {
            // Савенко В
            // Сделать статический класс для первой задачи + чтение из файла + обработка условия, если файл не найден
            MyArray Mr = new MyArray(20);
            for (int i = 0; i < Mr.array.Length; i++)
                Console.WriteLine((i + 1) + ": " + Mr.array[i]);

            Console.WriteLine("В массиве " + MyArray.DivideBy3() + " пар, где только одно из двух чисел делится на 3...");

            Console.WriteLine("\nЧтение из файла:");
            MyArray.ReadFile();
            MyArray.ShowArray();


        }
    }

    class MyArray
    {
        public MyArray(int length)
        {
            FillArray(length);
            
        }

        public static int[] Array;
        public static int[] ArrayFromFile;

        public int[]arrayFromFile
        {
            get { return ArrayFromFile; }
            set { ArrayFromFile = value; }
        }
        public int[] array
        {
            get { return Array;}
            set { Array = value; }
        }
        public static void ReadFile()
        {
            string fileName = @"..\\..\\data.txt";
            if (File.Exists(fileName))
            {
                string[] s = File.ReadAllLines(fileName);
                ArrayFromFile = new int[s.Length];
                for(int i=0; i<s.Length;i++)
                {
                    ArrayFromFile[i] = int.Parse(s[i]);
                }
            }
            else
                Console.WriteLine("File is not find...");
        }
        public static void FillArray(int length)
        {
            Array = new int[length];
            for (int i = 0; i < Array.Length; i++)
            {
                Random r = new Random();
                Array[i] = r.Next(-10000, 10000);
                Thread.Sleep(100);
            }
        }
        
        public static void ShowArray()
        {
            for(int j =0; j< ArrayFromFile.Length;j++)
                Console.WriteLine((1 + j) + ": " + ArrayFromFile[j]);
        }

        public static int DivideBy3()
        {
            int counter = 0;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] % 3 == 0 && Array[i + 1] % 3 != 0)
                    counter++;
                else if (Array[i] % 3 != 0 && Array[i + 1] % 3 == 0)
                    counter++;
            }
            return counter;
        }
    }
}
