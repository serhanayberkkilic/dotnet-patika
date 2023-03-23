using System;

/*
namespace operators
{
    class Program
    {
        static void Main (string[] args)
        {

            //atama ve işlemli atama operatörleri

            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(x);

            Console.WriteLine(y);
            y +=2;
            Console.WriteLine(y);
            y /=1;
            Console.WriteLine(y);
            y *=2;
            Console.WriteLine(y);

            //mantıksal operatörler

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            
                Console.WriteLine("Perfect");
            
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }

            if (isSuccess && !isCompleted)
            
                Console.WriteLine("Fine");
            

            //iliskisel operatörler

            // <,>,<=,>=,==,!=

            int a =3;
            int b =4;

            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;

            //aritmetik operatörler

            Console.WriteLine("İlişkisel Opretaörler");

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayi1*sayi2;

            Console.WriteLine(sonuc1);

            sonuc1 = sayi1++;
            Console.WriteLine(sayi1);

            // % mod alma
            int t =20%3;

            Console.WriteLine(t);
        }
    }
}
*/


using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static double solve(double meal_cost, int tip_percent, int tax_percent)
    {
        
        
        double tipCalculate=(meal_cost/100)*tip_percent;
        double taxCalculate=(meal_cost/100)*tax_percent;
        double result=tipCalculate+taxCalculate+meal_cost;
        double Number2 = Math.Round(result, MidpointRounding.AwayFromZero);
        Console.WriteLine(Number2);
        return Number2;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("meal_cost");
        double meal_cost = Convert.ToDouble(Console.ReadLine()!.Trim());
        Console.WriteLine("tip_percent");
        int tip_percent = Convert.ToInt32(Console.ReadLine()!.Trim());
        Console.WriteLine("tax_percent");
        int tax_percent = Convert.ToInt32(Console.ReadLine()!.Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}
