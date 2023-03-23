using System;




namespace NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int month = System.DateTime.Now.Month;


            switch (month)
            {

                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4: 
                    Console.WriteLine("April");
                    break;
                
                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }


            
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("First Quarter");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Second Quarter");
                    break;


                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }


        }
    }
}
