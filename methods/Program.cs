using System;




namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            int b=6;

            Console.WriteLine("Sum =" + (a+b));

            Console.WriteLine("With Func Sum =" + Add(a,b));

            Methods m = new Methods();
            m.Add(a, b);
            m.AddandUpgrade(ref a, ref b);
            Console.WriteLine("Default Sum =" + (a+b));
        }


        static int Add(int a, int b)
        {
            return a + b;
        }



    }

    class Methods
    {
        
        public void Add(int a, int b)
        {
            Console.WriteLine("With class public func Sum =" + (a + b));
        }

        public void AddandUpgrade(ref int a,ref int b)

        {
            a += 1;
            b += 1;
            Console.WriteLine("With class public(Use Referance) func Sum =" + (a + b));

        }

    }
}
