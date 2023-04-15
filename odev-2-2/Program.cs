using System;
using System.Collections.Generic;
using System.Collections;




namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList newlist = new ArrayList();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                newlist.Add(number);

            }
            Console.WriteLine("*********************");
            int sumofsamallest = 0;
            newlist.Sort();
            foreach (var item in newlist.GetRange(0, 3))
            {
                sumofsamallest += (int)item;
                Console.WriteLine(item);
            }
            Console.WriteLine("Sum of smallest three numbers: " + sumofsamallest);
            Console.WriteLine("Average of smallest three numbers: " + sumofsamallest / 3);

            int sumoflargest = 0;
            newlist.Reverse();
            foreach (var item in newlist.GetRange(0, 3))
            {
                sumoflargest += (int)item;
                Console.WriteLine(item);
            }
            Console.WriteLine("Sum of largest three numbers: " + sumoflargest);
            Console.WriteLine("Average of largest three numbers: " + sumoflargest / 3);

        }
    }
}
