using System;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Monday);

            int temp = 10;

            if (temp <= (int)weatherStatic.cold)
            {
                Console.WriteLine("It is cold");
            }
            else if (temp >= (int)weatherStatic.Normal && temp <= (int)weatherStatic.hot)
            {
                Console.WriteLine("It is normal");
            }
            else if (temp >= (int)weatherStatic.veryhot)
            {
                Console.WriteLine("It is very hot");
            }
            else if (temp >= (int)weatherStatic.cold && temp <= (int)weatherStatic.Normal)
            {
                Console.WriteLine("It is Not Bad");
            }
            else
            {
                Console.WriteLine("It is hot");
            }
        }
    }

    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum weatherStatic
    {
        cold = 5,
        Normal = 20,
        hot = 30,
        veryhot = 35
    }
}