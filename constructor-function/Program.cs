using System;



namespace constracture
{
    class Program
    {
        static void Main(string[] args)
        {

        workers workers1 = new workers();

        workers1.Name = "Samir";
        workers1.Surname = "Samirov";
        workers1.Age = 20;
        workers1.Department = "IT";

        workers1.ShowInfo();

        workers workers2 = new workers("Ali", "Aliyev", 25, "IT");
        
        workers2.ShowInfo();

        workers workers3 = new workers("veli","veliyev");

        workers3.ShowInfo();

        }
    }

    class workers
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Department;

        public workers()
        {
        }

        public workers(string name, string surname, int age, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Department = department;
        }

        public workers(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
        }

    }
}
