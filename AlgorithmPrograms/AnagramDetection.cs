using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class AnagramDetection
    {
        public bool isAnagram(string word1, string word2)
        {
            if(word1.Length == word2.Length)
            {
                word2.ToCharArray();
                string[] list1 = new string[word1.Length];
                string[] list2 = new string[word2.Length];
                int i = 0;
                foreach (char cha in word1)
                {
                    list1[i] = Convert.ToString(cha);
                    i++;
                }
                i = 0;
                foreach (char cha in word2)
                {
                    list2[i] = Convert.ToString(cha);
                    i++;
                }
                Array.Sort(list1);
                Array.Sort(list2);
                for ( i = 0; i < word1.Length; i++)
                {
                    if (list1[i] != list2[i])
                    {
                        Console.WriteLine($"{word1},{word2} are not anagram");
                        return false;
                    }
                }
                Console.WriteLine($"{word1},{word2} are anagram");
                return true;
            }
            Console.WriteLine($"{word1},{word2} are not anagram");
            return false;
        }
    }
}
