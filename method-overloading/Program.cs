using System;




namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string sayi = "12345&%6789";

            bool sayiTryparse =int.TryParse(sayi, out int sayi2);

            if (sayiTryparse==true)
            {
                Console.WriteLine("Convert is succesfull");
                Console.WriteLine(sayi2);
            }
            else
            {
                Console.WriteLine("Convert is failed");
            }

            methodOverloading methodOverloading = new methodOverloading();

            methodOverloading.method1(a: 1,b:2);

        }
    }

    class methodOverloading
    {
        public void method1(int a)
        {
            Console.WriteLine("Method1");
        }

        public void method1(int a, int b)
        {
            Console.WriteLine("Method2");
        }

        public void method1(int a, int b, int c)
        {
            Console.WriteLine("Method3");
        }
    }
}