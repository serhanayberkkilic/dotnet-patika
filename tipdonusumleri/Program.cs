using System;


namespace tipdonusum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Implicit Conversion (Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 30;
            short c=10;

            int d = a + b + c;
            Console.WriteLine("d: "+d);

            string e = "Serhan ayberk";
            string f = "Kilic";

            object fullName = e + " " + f;

            Console.WriteLine(fullName);


            // Explicit Conversion (Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: "+y);

            float w = 10.3f;

            Console.WriteLine("w: "+w);

            int z = (int)w;

            Console.WriteLine("z: "+z);


            // ***********ToString Method***********
            Console.WriteLine("***********ToString Method***********");

            int xx = 6;

            Console.WriteLine("xx: "+xx);
            string yy = xx.ToString();

            Console.WriteLine("yy: "+yy);


            // ***********System.Convert***********
            Console.WriteLine("***********System.Convert***********");

            string s1 = "10", s2 = "20";

            int sayi1 = Convert.ToInt32(s1);
            int sayi2 = Convert.ToInt32(s2);

            int toplam = sayi1 + sayi2;

            Console.WriteLine("toplam:"+toplam);

            // ***********Parse Method***********
            Console.WriteLine("***********Parse Method***********");

            ParseMethod();

        }

        private static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";

            int rakam1 = Int32.Parse(metin1);
            double ondalikliSayi = Double.Parse(metin2);

            Console.WriteLine("rakam1: "+rakam1);
            Console.WriteLine("ondalikliSayi: "+ondalikliSayi);
        }
    }
}
