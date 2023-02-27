using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTablePrograms
{
    public class WordCount
    {
        public static void wordcount()
        {
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Hashtable Freq = new Hashtable();


            string[] words = sentence.Split(' ');


            foreach (string word in words)
            {
                if (Freq.ContainsKey(word))
                {
                    int count = (int)Freq[word];
                    Freq[word] = count + 1;
                }
                else
                {
                    Freq.Add(word, 1);
                }
            }

            foreach (string word in Freq.Keys)
            {
                Console.WriteLine("{0}: {1}", word, Freq[word]);
            }
        }
    }
}
