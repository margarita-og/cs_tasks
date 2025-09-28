using System;
namespace MyProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Загадано число от 1 до 10, попробуйте его угадать");
            Random random = new Random();
            int secretNumber = random.Next(1, 11);
            bool guessed = false;
            string input = Console.ReadLine();
            while (guessed == false)
            {
                int number = int.Parse(input);
                if (number == secretNumber)
                {
                    guessed = true;
                    Console.WriteLine("Вы угадали!");
                    break;
                }
                else if (number < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                input = Console.ReadLine();
            }
        }
    }
}