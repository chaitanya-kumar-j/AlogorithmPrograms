using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            // run or exit
            bool IsRun = true;
            while (IsRun)
            {
                string filePath = @"G:\BridgeLabz\AlogorithmPrograms\AlgorithmPrograms\ListOfWords.txt";
                string numbersFilePath = @"G:\BridgeLabz\AlogorithmPrograms\AlgorithmPrograms\ListOfNumbers.txt";
                // Select Program number and enter
                Console.WriteLine("\nSelect and enter program number: " +
                    "(1. Search Word, 2. Insertion Sort)");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        bool IsInList = new SearchWord().IsInList(filePath);
                        break;
                    case 2:
                        new InsertionSort().InsertionSortWords(filePath);
                        break;
                    case 3:
                        new BubbleSort().BubbleSortNumbers(numbersFilePath);
                        break;
                    default:
                        IsRun = !IsRun;
                        break;
                }
            }
        }
    }
}
