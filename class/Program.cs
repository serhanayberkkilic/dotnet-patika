using System;






namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            Calisanslar calisan1 = new Calisanslar();

            calisan1.Name = "Ahmet";
            calisan1.Surname = "Yılmaz";
            calisan1.Age = 25;
            calisan1.No = 287348972;
            calisan1.Department = "IT";

            calisan1.CalisanBilgileri();

            Console.WriteLine("*************************");
            Calisanslar calisan2 = new Calisanslar();

            calisan2.Name = "Özge";
            calisan2.Surname = "İkinci";
            calisan2.Age = 19;
            calisan2.No = 823748283;
            calisan2.Department = "Sales";

            calisan2.CalisanBilgileri();
        }
    }


    class Calisanslar
    {

        public string Name;
        public string Surname;
        public int Age;

        public int No;
        public string Department;


        public void CalisanBilgileri()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("No: " + No);
            Console.WriteLine("Department: " + Department);
        }


    }
}