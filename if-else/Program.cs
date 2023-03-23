using System;



namespace if_else_namesapace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int hour = System.DateTime.Now.Hour;

            if (hour>=0 && hour<12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (hour>=12 && hour<18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }
        
            string sonuc = hour >= 18 ? "Good Evening" : "Good Morning";
            Console.WriteLine(sonuc);

            string sonuc2 = hour >= 18 ? "Good Evening" : hour >= 12 ? "Good Afternoon" : "Good Morning";

        }
    }
}