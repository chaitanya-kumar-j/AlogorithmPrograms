using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public string CompareTwoWords(string word1, string word2)
        {
            int length = Math.Min(word1.Length, word2.Length);
            int i = 0;
            while (i <= length)
            {
                if(word1.ToLower()[i] > word2.ToLower()[i])
                {
                    return word1;
                }
                if(word2[i] > word1[i])
                {
                    return word2;
                }
                else
                {
                    i++;
                }
            }
            return null;
        }
        public void InsertionSortWords(string filePath)
        {
            string data = File.ReadAllText(filePath);
            string[] ListOfWords = data.Split(",");
            Console.WriteLine("Words before sort are:");
            foreach (string word in ListOfWords)
            {
                Console.WriteLine(word);
            }
            int lenOfArray = ListOfWords.Length;
            for (int i = 1; i< lenOfArray; i++)
            {
                string currentWord = ListOfWords[i];
                int j = i - 1;
                while (j >= 0 && CompareTwoWords(ListOfWords[j], currentWord) == ListOfWords[j])
                {
                    ListOfWords[j + 1] = ListOfWords[j];
                    j = j - 1;
                }
                ListOfWords[j + 1] = currentWord;
            }
            Console.WriteLine("Words After sort are:");
            foreach (string word in ListOfWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
