using System;

namespace task6
{
    class Program
    {
        static int getCountGoodNumbers(int a, int b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                int sum = 0;
                int num = i;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (i % sum == 0)
                    count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            // *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1000000.
            // Хороши мназывается число, которое делится на сумму своих цифр. Реализовать подсчет
            // времени выполнения программы, используя структуру DateTime.
            DateTime fromTime = DateTime.Now;
            int count = getCountGoodNumbers(1, 1000000);
            DateTime toTime = DateTime.Now;
            Console.WriteLine("Число хороших чисел в диапазоне от 1 до 1000000 = {0}", count);            Console.WriteLine("Время выполнения: {0} мс", toTime.Subtract(fromTime).Milliseconds);            Console.ReadLine();
        }
    }
}
