using System;


namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {

            int deger = 2; 
            string degiskendegil = " ";
            //byte b=5; // 1byte
            //sbyte c=5; // 1byte

            //short s=5; // 2byte
            //ushort us=5; // 2byte

            //Int16 i16=2; // 2byte
            //int i=2; // 4byte
            //Int32 i32=2; // 4byte
            //Int64 i64=2; // 8byte

            //uint ui =2; // 4byte
            //long l=4; // 8byte
            //ulong ul=4; // 8byte

            //float f=5; // 4byte
            //double d=5; // 8byte
            //decimal de=5; // 16byte

            //char ch='2'; // 2byte
            //string str="2"; // sınırsız

            //bool b1=true; // 1byte
            //bool b2=false; // 1byte

            DateTime dt = DateTime.Now; // 8byte
            DateTime dt2 = DateTime.UtcNow; // 8byte
            

            Console.WriteLine(deger);
            Console.WriteLine(degiskendegil);
            Console.WriteLine("OnlyNow"+dt);
            Console.WriteLine("UtcNow: "+dt2);

            object o1="x"; // sınırsız
            object o2="y";
            object o3=4;
            object o4=4.3;

            //string ifadeler

            string str1 = string.Empty; //empty ifadeler için kullanılır


            //integer tanımlama şekilleri

            int integer1=5;
            int integer2=3;
            int integer3=integer1*integer2;
            Console.WriteLine("integer1*integer2 ="+integer3);

            //boolean

            bool bool1=10<2;
            Console.WriteLine(bool1);
            //değişken dönüşümleri
                //String Dönüşümleri

                string str20="20";
                int int20=20;
                string yenideger=str20+int20.ToString();
                Console.WriteLine(yenideger);
            
                //string ifadeyi integer a çevirme

                string str21="10";
                int int21=20;
                int int22= int21+Convert.ToInt32(str21);
                Console.WriteLine(int22);
        }
    }
}
