using System;




namespace arrayclass
{
    
    class Program
    {
        static void Main(string[] args)
        {

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

        }

    }

}