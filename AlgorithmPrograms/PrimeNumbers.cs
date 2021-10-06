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
        public void ListOfPrimes()
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
        }
    }
}
