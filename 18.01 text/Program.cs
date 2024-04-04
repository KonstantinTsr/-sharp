using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._01_text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = "";

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                text += line + "\r\n";
            }

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '(', ')', '-', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 3)
                {
                    if (wordCounts.ContainsKey(words[i]))
                    {
                        wordCounts[words[i]]++;
                    }
                    else
                    {
                        wordCounts.Add(words[i], 1);
                    }
                }
                
            }

            
            int maxCount = 0;
            string mostFrequentWord = "";
            foreach (KeyValuePair<string, int> pair in wordCounts)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostFrequentWord = pair.Key;
                }
            }

            Console.WriteLine("Самое частое слово: {0}", mostFrequentWord);
            Console.WriteLine("Количество в тексте: {0}", maxCount);
        }
    }
}
