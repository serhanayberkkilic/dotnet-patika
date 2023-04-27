using System;



namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Static Class");
            Console.WriteLine("Workers Count: " + Workers.WorkersCount);
            Workers worker1 = new Workers("John", "Doe", 25, 2500);
            Console.WriteLine("Workers Count: " + Workers.WorkersCount);
            Workers worker2 = new Workers("Barbie", "Ken", 18, 10000);
            Console.WriteLine("Workers Count: " + Workers.WorkersCount);
            worker1.Info();

            Console.WriteLine("Sum: " + Process.Sum(5, 10));
            Console.WriteLine("Extraction: " + Process.extraction(10, 5));

        }
    }

    class Workers
    {
        private static int workersCount = 0;


        private string name;
        private string surname;
        private int age;
        private int salary;

        public Workers(string name, string surname, int age, int salary)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salary = salary;
            workersCount++;
        }

        public static int WorkersCount { get => workersCount;}

        public void Info()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);
        }


    }

    static class Process
    {
        public static long Sum(int a, int b)
        {
            return a + b;
        }

        public static long extraction(int a, int b)
        {
            return a - b;
        }
    }
}