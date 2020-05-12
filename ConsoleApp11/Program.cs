using System;

namespace ConsoleApp11
{
    class Program
    {
        static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Введите размерность массива: ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Random rand = new Random();
                    a[i, j] = rand.Next(-100, 200);
                }
            return a;
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }

        static void Change(int[,] a)
        {
            double sum = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    sum += a[i, j];
            Console.WriteLine("Сумма всех элементов массива: " + sum);
            if (sum <= 999 && sum > 99) Console.WriteLine("Сумма является трехзначным числом");
            else Console.WriteLine("Сумма не является трехзначным числом");
        }
    

    static void Main()
        {
            try
            {
                int n, m;
                int[,] myArray = Input(out n, out m);
                Console.WriteLine("Исходный массив:");
                Print(myArray);
                Change(myArray);
            }
            catch { Console.WriteLine("Некорректный ввод!"); }
        }
    }

}

