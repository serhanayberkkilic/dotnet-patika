using System;



namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            student student1 = new student("Ali", "Veli", 20, 123, 1);

            student1.studentInfo();
            student1.classDowngrade();
            student1.studentInfo();
            student1.classUpgrade();
            student1.studentInfo();
        }
    }

    class student
    {
        private string Name;
        private string Surname;
        private int Age;
        private int StudentNumber;

        private int ClassNumber;
        

        public string name { get => Name; set => Name = value; }
        public string surname { get => Surname; set => Surname = value; }
        public int age { get => Age; set => Age = value; }
        public int studentNumber { get => StudentNumber; set => StudentNumber = value;}
        public int classNumber { 
            get => ClassNumber; 
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Class number can not be zero or less than zero");
                }
                else
                {
                    ClassNumber = value;
                }
            }
            
            }

        public student(string name, string surname, int age, int studentNumber, int classNumber)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.StudentNumber = studentNumber;
            this.classNumber = classNumber;
        }

        public void studentInfo()
        {
            Console.WriteLine("***********Student Information*******");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Student Number: " + studentNumber);
            Console.WriteLine("Class Number: " + classNumber);
        }

        public void classUpgrade()
        {
            this.classNumber++;
        }

        public void classDowngrade()
        {
            this.classNumber--;
        }
    }
}
