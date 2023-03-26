using System;


namespace for_loop
{
    class Program
    {
        /*static void Main(string[] args)
        {
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("i = {0}", i);
            }
            Console.WriteLine("i = {0}", i);
        }*/

        /*static void Main(string[] args)
        {
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine("i = {0}", i);
            }
        }*/

        static void Main(string[] args)
        {
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("i = {0}", i);
            }
        }
    }
}