using System;
using System.Text;
using System.Linq;

namespace lab5
{
    class Program
    {
        static bool CheckStringBuilderString(StringBuilder stringbuilderString)
        {
            // Проверяем длину строки
            if (stringbuilderString.Length > 200)
            {
                Console.WriteLine("Ошибка длинна строки больше 200");
                return false;
            }
            if (stringbuilderString.ToString().Contains("  ")|| stringbuilderString.ToString()[0]==' ')
            {
                Console.WriteLine("Ошибка каждому слову, кроме первого, предшествует один пробел");
                return false;
            }
            // Разбиваем строку на предложения
            string[] sentences = stringbuilderString.ToString().Split(new char[] { '!', '?', '.', '\u2026' });
            string[] sentencesf = sentences.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            int t = 0;
            foreach (string sentence in sentencesf)
            {
                Console.WriteLine(t + "_" + sentence);
                t++;
            }
            // Проверяем количество предложений
            if (sentencesf.Length < 3)
            {
                Console.WriteLine("Ошибка количество предложений меньше трех");
                return false;
            }
            // Проверяем каждое предложение
            foreach (string sentence in sentencesf)
            {
                // Проверяем первую букву предложения
                if (!char.IsUpper(sentence.Trim()[0]))
                {
                    Console.WriteLine("Ошибка первая буква предложения должна быть большой");
                    return false;
                }
                
                string[] words = sentence.Split(' ');
                foreach (string word in words)
                {
                    if (word.Contains(',') && (word[word.Length - 1] != ','))
                    {
                        Console.WriteLine("Ошибка знаков препинания");
                        return false;
                    }
                }
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            StringBuilder n;
            Console.WriteLine("Введите строку");
            n = new StringBuilder(Console.ReadLine());
            while (!CheckStringBuilderString(n))
            {
                n = new StringBuilder(Console.ReadLine());
            }
            int p = -1;
            if (n.Length % 2 == 0)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] == ' ')
                    {
                        p = i;
                        break;
                    }
                }
                if (p == -1)
                {
                    Console.WriteLine("Пробела нет");
                }
                else
                {
                    n.Remove(0,p);
                }
            }
            Console.WriteLine($"Ответ:\n{n}");
            Console.ReadLine();
        }
    }
}
