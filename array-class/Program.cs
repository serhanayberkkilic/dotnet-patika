using System;




namespace arrayclass
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int [] numbers = {2,23,3,42,17};
            // Not Sorted Array

            Console.WriteLine("************Not Sorted Array*********");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Array.Sort(numbers);
            //Sorted Array
            Console.WriteLine("******Sorted Array********");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("***********Clear************");

            Array.Clear(numbers,2,2);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //indexOff
            Console.WriteLine("*********indexoff******");
            
            Console.WriteLine("42:"+Array.IndexOf(numbers,42));
            */


            int[]  newlist = {2,16,21,3,4,21,5,6,7,8,9,10,11,12,13,14,15,16,17,18,21,19,20,16};

            Console.WriteLine("*********indexoff******");
            
            int maxValue = newlist.Max(t => t);
            int value = Array.FindAll(newlist, t => t == maxValue).Length;
            Console.WriteLine("Max Value: {0}  Max Value Index: {1}", maxValue,value);

        }

    }

}