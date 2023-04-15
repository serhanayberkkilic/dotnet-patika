using System;



namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>();
            liste.Add("Hello");
            liste.Add("World");
            liste.Add("!");

            Console.WriteLine(liste.Count);

            foreach (var item in liste)
                Console.WriteLine(item);

            List<int> liste2 = new List<int>(){3,2,4,5,2,99,23,24,87,0};

            liste2.Add(100);
            liste2.Add(11);

            foreach (var item in liste2)
                Console.WriteLine(item);

            Console.WriteLine("*******Sort********");

            liste2.Sort();

            foreach (var item in liste2)
                Console.WriteLine(item);

            liste2.Remove(100);
            liste2.Remove(11);

            foreach (var item in liste2)
                Console.WriteLine(item);
            

            Console.WriteLine("*******Search********");

            Console.WriteLine(liste2.BinarySearch(87));

            int [] dizi = new int[4];

            dizi[0] = 1;
            dizi[1] = 2;
            dizi[2] = 3;

            Console.WriteLine("*******Array********");

            foreach (var item in dizi)
                Console.WriteLine(item);

            //Convert Array to List

            Console.WriteLine("*******Array to List********");

            List<int> liste3 = dizi.ToList();

            foreach (var item in liste3)
                Console.WriteLine(item);

            liste3.Clear();

            Console.WriteLine("*******Users Class********");

            Users user = new Users();

            user.Name = "Mehmet";
            user.Surname = "Yılmaz";
            user.Age = 25;

            Console.WriteLine(user.Name);
            Console.WriteLine(user.Surname);
            Console.WriteLine(user.Age);

        }

    }


    class Users
    {
        private string name;

        private string surname;

        private int age;

        public string Name{get => name; set => name = value;}

        public string Surname{get => surname; set => surname = value;}

        public int Age{get => age; set => age = value;}

    }
}