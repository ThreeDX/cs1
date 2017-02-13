using System;


namespace dz2
{
    class Program
    {
        // а) Разработать рекурсивный метод, который выводит на экран числа от a до b;
        static void showABNumbers(int a, int b)
        {
            if (a > b)
            {
                showABNumbers(b, a);
                return;
            }
            Console.WriteLine(a);
            if (a == b)
                return;
            showABNumbers(++a, b);
        }

        // б) *Разработатьрекурсивный метод, который считает сумму чисел от a до b.
        static int getSumABNumbers(int a, int b)
        {
            if (a > b)
                return getSumABNumbers(b, a);
            if (a == b)
                return a;
            return a + getSumABNumbers(++a, b);

        }

        static void Main(string[] args)
        {
            // а) Разработать рекурсивный метод, который выводит на экран числа от a до b;
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            showABNumbers(a, b);

            // б) *Разработатьрекурсивный метод, который считает сумму чисел от a до b.
            Console.WriteLine("Сумма чисел от a до b = {0}", getSumABNumbers(a, b));

            Console.ReadLine();
        }
    }
}
