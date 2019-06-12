using System;

namespace task_three
{
    class Program
    {
        static void Main(string[] args)
        {
            // Савенко В.Р.
            // Дописать класс работы с одномерным массивом
            // массив создаётся в виде конструктов
          
            Console.Write("Массив с шагом:");
            MyArray mr = new MyArray(10, 1, 10, 10); //  с шагом и определённой длины
            MyArray.Show();
            Console.WriteLine("\nСумма элементов: "+ mr.Sum);

            Console.WriteLine("\nПеревёрнутый массив: ");
            for (int i = 0; i < MyArray.Inverse().Length; i++)
                Console.WriteLine((i+1)+": "+MyArray.Inverse()[i].ToString());
            Console.WriteLine("\nУмножили на число: ");
            MyArray.Multi(23);
            MyArray.Show();

            Console.WriteLine("\nКол-во максимальных элементов: " + mr.MaxCount);
           
        }
    }

    class MyArray
    {

        static int[] a;
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }

        public MyArray(int length, int min, int max, int step)
        {
            a = new int[length];
            Random rnd = new Random();
            a[0] = rnd.Next(min, max);
            for (int i = 1; i < length; i++)
                a[i] = a[i - 1] + step;
        }

        public int[]show
            {
                get 
                {
                    return a;
                }
            }

        public static void Show()
        {
            for(int i = 0; i< a.Length;i++)
                Console.WriteLine((i+1)+ ": "+a[i].ToString());
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        public int MaxCount
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == this.Max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

        public static int[] Inverse()
        {
            int[] newArray = new int[a.Length];

            for (int i = 0; i < newArray.Length; i++)
                newArray[i] = -a[i];

            return newArray;
        }

        public static void Multi(int Mn)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] *= Mn;
        }
    }

}

