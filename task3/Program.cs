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

            string input = Console.ReadLine();
            int number;

            while (true)
            {
                bool isSuccess = int.TryParse(input, out number);
                if (isSuccess)
                {
                    if (number == secretNumber)
                    {
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
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }

                input = Console.ReadLine();
            }
        }
    }
}