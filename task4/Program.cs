using System;
namespace MyProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Придумайте пароль");
            string password = Console.ReadLine();
            bool isCorrect = false;
            while (isCorrect == false)
            {
                bool containsDigit = false;
                bool containsUpper = false;
                bool containsSpecial = false;
                if (password.Length < 8)
                {
                    Console.WriteLine("Длина должна быть не менее 8 символов, придумайте другой");
                    password = Console.ReadLine();
                    continue;
                }
                foreach (char symbol in password)
                {
                    if ("0123456789".Contains(symbol))
                    {
                        containsDigit = true;
                    }
                    if (char.IsUpper(symbol))
                    {
                        containsUpper = true;
                    }
                    if ("!@#$%^&*".Contains(symbol))
                    {
                        containsSpecial = true;
                    }
                }
                if (containsDigit == false)
                {
                    Console.WriteLine("Пароль должен содержать хотя бы одну цифру, придумайте другой");
                    password = Console.ReadLine();
                    continue;
                }
                if (containsSpecial == false)
                {
                    Console.WriteLine("Пароль должен содержать хотя бы один специальный символ (!@#$%^&*), придумайте другой");
                    password = Console.ReadLine();
                    continue;
                }
                if (containsUpper == false)
                {
                    Console.WriteLine("Пароль должен содержать хотя бы одну заглавную букву, придумайте другой");
                    password = Console.ReadLine();
                    continue;
                }
                isCorrect = true;
            }
            Console.WriteLine("Такой пароль подходит!");
        }
    }
}
