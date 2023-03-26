using System;



namespace array
{
    class Program
    {

        static void Main(string[] args)
        {
            //dizi tanımlama
            int[] sayilar = new int[5];
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;
            sayilar[3] = 4;
            sayilar[4] = 5;

            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[1]);
            Program.ndizi(args);
            
        }

        static void ndizi(string[] args)
        {
            //klavyeden girilen n sayıyı diziye atayıp ekrana yazdırma
            Console.Write("Dizi boyutu giriniz: ");
            int sayilarlength =Convert.ToInt32(Console.ReadLine());
            
            int[] sayilar = new int[sayilarlength];
            int total=0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0}.sayiyi giriniz: ",i+1);
                int currentSayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = currentSayi;
                total += currentSayi;
            }
            Console.WriteLine("Toplam: {0} Ortalama: {1} ",total,total/sayilarlength);
        }
    }
}