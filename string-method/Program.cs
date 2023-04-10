using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Hello World";
            string value2 = "Hello World My name is ayberk";
            string value3 = "My name is ayberk";


            Console.WriteLine(value);
            Console.WriteLine(value2);

            value=value.ToUpper();
            Console.WriteLine("Upper: "+value);
            Console.WriteLine("Length: "+value.Length);

            string value4;
            value4=string.Concat(value,value3);
            Console.WriteLine("Concat: "+value4);

            Console.WriteLine("Compare: "+string.Compare(value2,value4)); // can add true or false for case sensitive

            Console.WriteLine("Contains: "+value2.Contains(value3));

            Console.WriteLine("EndsWith: "+value2.EndsWith(value3));

            Console.WriteLine("IndexOf: "+value2.IndexOf(value3));

            Console.WriteLine("Insert: "+value.Insert(11,value3));

            Console.WriteLine("Remove: "+value.Remove(5));

            Console.WriteLine("Replace: "+value.Replace("Hello","Hi"));

            Console.WriteLine("Split: "+value.Split(' '));

            Console.WriteLine("StartsWith: "+value.StartsWith("Hello"));

            Console.WriteLine("Substring: "+value.Substring(6));

            Console.WriteLine("Trim: "+value.Trim());

            Console.WriteLine("LastIndexOf: "+value.LastIndexOf("l"));
        }
    }
}
