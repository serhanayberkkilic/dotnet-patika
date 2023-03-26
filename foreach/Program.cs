using System;




namespace foreachNamespace
{
    
    class Program
    {
        /// While loop
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            int toplam = 0;

            while (sayac<=number)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Toplam: {0}, Ortalama: {1}", toplam, toplam / number);
            Program.test2(args);
            

        }

        //a dan z ye kadar yazdırma
        static void test2(string[] args)
        {
            char ch = 'a';
            while (ch<='z')
            {
                Console.Write(ch + " ");
                ch++;
            }
        }

        

    }
}