using System;

namespace Task1
{
    class Program
    {
        static void RandomColor()
        {
            Random random = new Random();
            Console.BackgroundColor = (ConsoleColor)random.Next(0, 16);
            Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
            Console.Clear();
        }

        static void Main(string[] args)
        {
            string firstName = "", lastName = "";

            RandomColor();

            Console.Write("Введите Вашу фамилию: ");
            lastName = Console.ReadLine();
            Console.Write("Введите Ваше имя: ");
            firstName = Console.ReadLine();
            Console.WriteLine("\nЗдравствуйте, " + lastName + " " + firstName + "!");


            Console.Title = (firstName);
            Console.SetWindowSize(50, 50);

            Console.Beep();

            Console.WriteLine("Caps Lock: " + (Console.CapsLock ? "On" : "Off"));
            Console.WriteLine("Num Lock: " + (Console.NumberLock ? "On" : "Off"));

            Console.CursorVisible = false;
            Console.ReadKey(true);
        }
    }
}
