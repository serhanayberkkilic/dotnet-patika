using System;
using Namespace;


namespace PhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            while (true)
            {
                process.ChoiceProcess();
                int choice = Convert.ToInt32(Console.ReadLine());
                process.ChoiceProcess(choice);
                if (choice == 6)
                {
                    break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}