using System;
namespace MyProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();

            if (text.Length == 0)
            {
                Console.WriteLine("Вы ничего не ввели");
                return;
            }
            
            string[] words = text.Split(' ');
            char point = '.';
            char exclamationMark = '!';
            char questionMark = '?';
            string punctuation = ".,!?:;()%'\"/";
            int totalLen = 0;
            Dictionary<string, int> wordsCounter = new Dictionary<string, int>();

            Console.WriteLine($"Количество слов: {words.Length}");
            Console.WriteLine($"Количество предложений: {text.Count(c => c == point) + text.Count(c => c == exclamationMark) + text.Count(c => c == questionMark)}");

            for (int i = 0; i < words.Length; i++)
            {
                foreach (char mark in punctuation)
                {
                    if (words[i].EndsWith(mark) || words[i].EndsWith(mark))
                    {
                        words[i] = words[i].Substring(0, words[i].Length - 1);
                    }
                    if (words[i].StartsWith(mark) || words[i].StartsWith(mark))
                    {
                        words[i] = words[i].Substring(1, words[i].Length - 1);
                    }
                }
                if (!wordsCounter.ContainsKey(words[i]))
                {
                    wordsCounter.Add(words[i], 1);
                }
                else
                {
                    wordsCounter[words[i]]++;
                }
                totalLen += words[i].Length;
            }
            
            var maxWord = wordsCounter.OrderByDescending(x => x.Value).First().Key;
            Console.WriteLine($"Самое частое слово: {maxWord}");
            Console.WriteLine($"Средняя длина слова: {totalLen / words.Length}");
        }
    }
}