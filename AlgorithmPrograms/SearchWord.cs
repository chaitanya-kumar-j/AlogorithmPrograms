using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    class SearchWord
    {
        public bool IsInList(string filePath)
        {
            string data = File.ReadAllText(filePath);
            string[] ListOfWords = data.Split(",");
            Console.WriteLine("Enter the word to search: ");
            string wordToSearch = Console.ReadLine().ToLower();
            foreach(string word in ListOfWords)
            {
                if(wordToSearch == word.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
