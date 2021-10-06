using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    class MergeSort
    {
        public void MergeSortWords(string filePath)
        {
            string data = File.ReadAllText(filePath);
            string[] listOfWords = data.Split(",");
            int length = listOfWords.Length;
            int mid = length / 2 +1;
            string[] leftTemp = new string[mid];
            string[] rightTemp = new string[length - mid];
            for (int i = 0; i < mid; i++)
            {
                leftTemp[i] = listOfWords[i];
                rightTemp[i] = listOfWords[mid + i];
            }

        }
    }
}
