using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру в градусах Цельсия");
            string input = Console.ReadLine();
            int temperatureC;
            bool isSuccess = int.TryParse(input, out temperatureC);
            if (isSuccess)
            {
                double temperatureF = temperatureC * 1.8 + 32;
                Console.WriteLine($"Это {temperatureF} градусов Фаренгейта");
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }
}