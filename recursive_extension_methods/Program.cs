using System;



namespace recursive_extention_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive Method
            Console.WriteLine("********Recursive Method********");

            int baseNumber = 2;
            int power = 3;
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result = result * baseNumber;
            }
            Console.WriteLine("For Loop exponential Numbers: "+result);
            Islemler islemler = new Islemler();
            Console.WriteLine("Recursive Method exponential Numbers: "+Islemler.Exponential(baseNumber, power));

            //Extention Method
            Console.WriteLine("********Extention Method********");

            string ifade = "C# Extention Method";
            Console.WriteLine("Original: "+ifade);
            Console.WriteLine("RemoveWhiteSpaces: "+ifade.RemoveWhiteSpaces());
            
        }







    }

    class Islemler
    {
        public static int Exponential(int baseNumber, int power)
        {
            if (power < 2)
            {
                return baseNumber;
            }
            return Exponential(baseNumber, power - 1) * baseNumber;
        }
    }


    public static class Extention
    {
        public static string RemoveWhiteSpaces(this string param)
        {
            return param.Replace(" ", "");
        }
    }

}