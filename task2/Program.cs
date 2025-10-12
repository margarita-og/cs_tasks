using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа по одному, чтобы просуммировать их, для завершения программы введите 0");
            string input = Console.ReadLine();
            int number;
            int sum = 0;
            while (input != "0")
            {
                bool isSuccess = int.TryParse(input, out number);
                if (isSuccess)
                {
                    sum += number;
                    Console.WriteLine($"Текущая сумма {sum}");
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