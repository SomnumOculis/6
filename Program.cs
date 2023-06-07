using System;

namespace blokcxema.zadacha_6.sem2
{
    class Program
    {
        static void Main()
        {
            int a, n, i, c = 0, j;

            Console.WriteLine("Введите количество элементов массива: ");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторить ввод данных? (1-yes, 0-no): ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) {Main();}
                return;
            }
            Random rand = new Random();
            int[] array = new int[n];
            Console.WriteLine("Исходный массив:");
            for (i = 0; i < n; i++)
            {
                array[i] = rand.Next(-3, 4);
                Console.Write("{0,3}", array[i]);
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - 1; j++)
                {
                    if ((array[j] > 0 && array[j + 1] < 0) || (array[j] == 0 && array[j + 1] < 0) || (array[j] > 0 && array[j + 1] == 0))
                    {
                        c = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = c;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив:");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0,3}", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(" Повторить ввод данных? ( 1-yes, 0-no ): ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) { Main(); }
            return;
        }
    }
}
