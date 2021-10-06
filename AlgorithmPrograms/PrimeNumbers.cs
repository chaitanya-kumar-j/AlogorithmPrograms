using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumbers
    {
        static bool isPrime(int n)
        {
            // if number less than or equal to 1
            if (n <= 1)
            {
                return false;
            }
            // Check from 2 to n-1
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public List<int> ListOfPrimes()
        {
            Console.WriteLine("Enter the range of numbers.\nEnter the starting number in range: ");
            int lowest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number in range: ");
            int highest = Convert.ToInt32(Console.ReadLine());
            while (highest < lowest)
            {
                Console.WriteLine("number should be greater than starting number");
                Console.WriteLine("Enter the correct last number in range: ");
                highest = Convert.ToInt32(Console.ReadLine());
            }
            List<int> listOfPrimes = new List<int>();
            int j = 0;
            for(int i = lowest; i <= highest; i++)
            {
                if (isPrime(i))
                {
                    j++;
                    listOfPrimes.Add(i);
                }
            }

            Console.WriteLine($"Number of primes in the range {lowest} and {highest} are {j} and list is: ");
            foreach(int number in listOfPrimes)
            {
                Console.Write(number+" ");
            }
            return listOfPrimes;
        }
        public bool isAnagram(string word1, string word2)
        {
            if (word1.Length == word2.Length)
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
                for (i = 0; i < word1.Length; i++)
                {
                    if (list1[i] != list2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public bool isPalindrome(string word)
        {
            string newWord = "";
            foreach(char cha in word)
            {
                newWord = cha+newWord;
            }
            if (word == newWord)
            {
                return true;
            }
            return false;
        }
        public void PrimesWithPalindromeAndAnagram()
        {
            List<int> listOfPrimes = new PrimeNumbers().ListOfPrimes();
            List<int> palindromeAndAnagramList = new List<int>();
            Console.WriteLine("\nList of prime numbers that are anagram and palindrome are: ");
            for (int i = 0;i<listOfPrimes.Count;i++)
            {
                for(int j = 1; j < listOfPrimes.Count; j++)
                {
                    if (i!=j && isAnagram(Convert.ToString(listOfPrimes[i]), Convert.ToString(listOfPrimes[j])))
                    {
                        if (isPalindrome(Convert.ToString(listOfPrimes[j])))
                        {
                            palindromeAndAnagramList.Add(listOfPrimes[i]);
                            Console.WriteLine($"{listOfPrimes[i]} - {listOfPrimes[j]}");
                        }
                    }
                }
            }
            //foreach(int prime in palindromeAndAnagramList)
            //{
            //    Console.Write(prime + " ");
            //}
        }
    }
}
