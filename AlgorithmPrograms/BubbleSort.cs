using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        public void BubbleSortNumbers(string filePath)
        {
            string data = File.ReadAllText(filePath);
            string[] listOfNumber = data.Split(",");
            int[] listOfNumbers = Array.ConvertAll(listOfNumber, int.Parse);
            Console.WriteLine("Array before Bubble sort: ");
            foreach(int number in listOfNumbers)
            {
                Console.Write(number + " ");
            }
            int length = listOfNumbers.Length;
            bool isSwap = true;
            while (isSwap)
            {
                bool swapped = false;
                for(int i = 1; i < length; i++)
                {
                    if (listOfNumbers[i] < listOfNumbers[i - 1])
                    {
                        swapped = true;
                        int temp = listOfNumbers[i];
                        listOfNumbers[i] = listOfNumbers[i - 1];
                        listOfNumbers[i - 1] = temp;
                    }
                }
                if (!swapped)
                {
                    isSwap = !isSwap;
                }
            }
            Console.WriteLine("\nArray After Bubble sort: ");
            foreach (int number in listOfNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
