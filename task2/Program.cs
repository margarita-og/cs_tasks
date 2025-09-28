using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа по одному, чтобы просуммировать их");
            string input = Console.ReadLine();
            int sum = 0;
            while (input != "0")
            {
                int number = int.Parse(input);
                sum += number;
                Console.WriteLine(sum);
                input = Console.ReadLine();
            }
        }
    }
}