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
                // Select Program number and enter
                Console.WriteLine("Select and enter program number: " +
                    "(1. Search Word)");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        bool IsInList = new SearchWord().IsInList(filePath);
                        if (IsInList)
                        {
                            Console.WriteLine("The searched word is in file.");
                        }
                        else
                        {
                            Console.WriteLine("The searched word is not in file.");
                        }
                        break;
                    case 2:
                        new InsertionSort().InsertionSortWords(filePath);
                        break;
                    default:
                        IsRun = !IsRun;
                        break;
                }
            }
        }
    }
}
