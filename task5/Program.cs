using System;
namespace MyProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            char point = '.';
            Console.WriteLine($"Количество слов: {words.Length}");
            Console.WriteLine($"Количество предложений: {text.Count(c => c == point)}");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].EndsWith(".") || words[i].EndsWith(","))
                {
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                }
            }
            string maxWord = "";
            int maxWordCount = 0;
            int totalLen = 0;
            foreach (string word in words)
            {
                totalLen += word.Length;
                if (words.Count(c => c == word) > maxWordCount)
                {
                    maxWord = word;
                    maxWordCount = words.Count(c => c == word);
                }
            }
            Console.WriteLine($"Самое частое слово: {maxWord}");
            Console.WriteLine($"Средняя длина слова: {totalLen / words.Length}");
        }
    }
}