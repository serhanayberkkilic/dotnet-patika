using System;
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList primes = new ArrayList();
            ArrayList nonPrimes = new ArrayList();
            int sumopfPrimes = 0;
            int sumofNonPrimes = 0;
            for (int i = 0; i < 20; i++)
            {
                int number = 0;
                bool validInput = false;
                Console.WriteLine("Enter a number: ");
                //read the number from the console only positive numbers
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                {
                    validInput = true;
                }
                else {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
                if (validInput)
                {
                    if (IsPrime(number))
                    {
                        sumopfPrimes += number;
                        primes.Add(number);
                    }
                    else
                    {
                        sumofNonPrimes += number;
                        nonPrimes.Add(number);
                    }
                }
            }
            
            primes.Sort();
            nonPrimes.Sort();

            Console.WriteLine("Mean Primes: "+ sumopfPrimes/primes.Count);
            Console.WriteLine("Mean Non Primes: " + sumofNonPrimes/nonPrimes.Count);

            foreach (int prime in primes)
            {
                Console.WriteLine("Prime: " + prime);
            
            }
            
            foreach (int nonPrime in nonPrimes)
            {
                Console.WriteLine("Non Prime: " + nonPrime);
            }

        }


        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
                
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
            
            return true;        
        }


    }
}
