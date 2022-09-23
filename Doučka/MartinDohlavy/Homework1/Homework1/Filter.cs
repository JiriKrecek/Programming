using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Filter
    {
        public void Run()
        {
            Console.WriteLine("Načítám slova.");
            string[] words = File.ReadAllLines("words.txt");
            Console.WriteLine("Slova načtena.");

            Console.Write("Slova začínající jakým znakem, chcete vyfiltrovat: ");
            char startingLetter = Console.ReadLine().Trim()[0];

            List<string> filteredWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word[0] == startingLetter)
                {
                    filteredWords.Add(word);
                }
            }

            Console.WriteLine($"Celkově vyfiltrováno {filteredWords.Count} slov.");

            Console.WriteLine("Ukládání slov do output.txt");
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < filteredWords.Count; i++)
                {
                    sw.WriteLine(filteredWords[i]);
                }
            }
            Console.WriteLine("Slova uložena.");
        }
    }
}
