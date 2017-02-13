using System;

namespace task4
{
    class Program
    {

        static bool checkAuth(string login, string password)
        {
            if (login == "test" && password == "1234")
                return true;
            else
                return false;
        }

        static bool processAuth()
        {
            int i = 3;
            bool auth = false;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                auth = checkAuth(login, password);
                if (!auth)
                    Console.WriteLine("Неверные логин или парооль!");
                i--;
            } while (i > 0 && !auth);
            return auth;
        }

        static void Main(string[] args)
        {
            // Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе
            // истина, если прошелавторизацию, и ложь, еслине прошел. Используя методпроверки логинаи
            // пароля, написатьпрограмму: пользователь вводитлогин ипароль, программа пропускаетего
            // дальшеили непропускает.С помощьюциклаdo whileограничитьввод паролятремяпопытками;

            if (processAuth())
                Console.WriteLine("Успешная авторизация!");
            else
                Console.WriteLine("Авторизация не удалась!");

            Console.ReadLine();
        }
    }
}
