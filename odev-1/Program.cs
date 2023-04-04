using System;



namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            positiveNumbers();
            positive2Numbers();
            words();
            sentence();


        }

        static void positiveNumbers()
        {
            int n;
            Console.WriteLine("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} Enter the number : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in arr)
            {
                if (item%2==0)
                {
                    Console.WriteLine("The number is even {0}", item);
                }

            }



        }

        static void positive2Numbers()
        {

            int n;
            int m;
            Console.WriteLine("Enter the number(n) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number(m) : ");
            m= Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} Enter the number : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in arr)
            {
                if (item%m==0 | item==m)
                {
                    Console.WriteLine("The number is {0}", item);
                }

            }

        }
    
        static void words()
        {

            int n;
            
            Console.WriteLine("Enter the number(n) : ");
            n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} Enter the word : ",i);
                arr[i] = Console.ReadLine();

            }
            Console.WriteLine("*************The words are : **************");
            arr.Reverse();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }

        static void sentence()
        {

            string sentence;
            Console.WriteLine("Enter the sentence : ");
            sentence = Console.ReadLine();
            string[] arr = sentence.Split(" ");
            Console.WriteLine("*************The words are : **************");
            Console.WriteLine("The number of words is : {0}", arr.Length);
            int letterCount = 0;
            foreach (var item in arr)
            {
                letterCount += item.Length;
            }
            Console.WriteLine("The number of letters is : {0}", letterCount);
        }

    
    }
}
