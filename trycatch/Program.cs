using System;


namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero"+ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number Message: "+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution");
            }



        }
    }
}
