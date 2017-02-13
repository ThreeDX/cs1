using System;

namespace ConsoleApplication1
{
    class Program
    {
        const double MIN_IMT = 18.5;
        const double MAX_IMT = 24.99;

        static double getIMT(double h, double m)
        {
            if (h == 0)
                return 0;
            return m / (h * h);
        }

        static void Main(string[] args)
        {
            // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
            // массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса

            double h, m;
            Console.Write("Введите свой рост (см): ");
            h = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Введите свой вес (кг): ");
            m = Convert.ToDouble(Console.ReadLine());

            double i = getIMT(h, m);

            if (i != 0)
            {
                Console.WriteLine("Индекс массы тела: {0:0.##}", i);
                if (i > MAX_IMT)
                {
                    Console.WriteLine("Вам нужно похудеть минимум на {0:0.##} кг.", m - MAX_IMT * h * h);

                }
                else if (i < MIN_IMT)
                {
                    Console.WriteLine("Вам нужно набрать вес минимум на {0:0.##} кг.", MIN_IMT * h * h - m);
                }
                else
                {
                    Console.WriteLine("Ваш вес в пределах допустимого.");
                }
                
            }
            else
            {
                Console.WriteLine("Введены некорректные данные.");
            }
            Console.ReadLine();
        }
    }
}
