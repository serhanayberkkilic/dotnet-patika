using System;
using System.Collections;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create Array List

            ArrayList myAL = new ArrayList();

            //Add items to the ArrayList
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");
            myAL.Add(12);
            myAL.Add(3.14);

            //Display the ArrayList
            Console.WriteLine("The ArrayList contains the following:");
            foreach (object obj in myAL)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("******Indexing********");
            Console.WriteLine(myAL[0]);

            foreach (var item in myAL)
            {
                Console.WriteLine(item);
            }
            
            List<string> myALlist = new List<string>();
            myALlist.Add("Hello List");
            myALlist.Add("World List");
            myALlist.Add("! List");
            
            myAL.AddRange(myALlist);

            Console.WriteLine("The ArrayList contains the following:");
            foreach (var item in myAL)
            {
                Console.WriteLine(item);
            }

            //myAL.Sort();

            //Console.WriteLine("*****Sorted ArrayList*****");
            //foreach (var item in myAL)
            //{
            //    Console.WriteLine(item);
            //}

            myAL.Reverse();

            Console.WriteLine("*****Reversed ArrayList*****");
            foreach (var item in myAL)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*****Clear*****");

            myAL.Clear();
        }
    }
}