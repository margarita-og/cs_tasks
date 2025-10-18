using System;
namespace MyProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Придумайте пароль");
            string password;
            bool isCorrect = false;
            while (!isCorrect)
            {
                password = Console.ReadLine();
                bool containsDigit = false;
                bool containsUpper = false;
                bool containsSpecial = false;

                if (password.Length < 8)
                {
                    Console.WriteLine("Длина должна быть не менее 8 символов, придумайте другой");
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

                if (!containsDigit)
                {
                    Console.WriteLine("Пароль должен содержать хотя бы одну цифру, придумайте другой");
                }
                if (!containsSpecial)
                {
                    Console.WriteLine("Пароль должен содержать хотя бы один специальный символ (!@#$%^&*), придумайте другой");
                }
                if (!containsUpper)
                {
                    Console.WriteLine("Пароль должен содержать хотя бы одну заглавную букву, придумайте другой");
                }
                isCorrect = containsDigit && containsSpecial && containsUpper && (password.Length >= 8);
            }
            
            Console.WriteLine("Такой пароль подходит!");
        }
    }
}
