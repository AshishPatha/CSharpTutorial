using System;
using System.IO;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Value Types 
            // int       
            // k is declared but never used
            // j is Declared and Initilized
            // m is declared and Intilized based on J
            // p is negative integer
            int k,j=10,m,p=-98;
            k = 5;
            m = j + 19;
            Console.WriteLine("J : " + j);            
            Console.WriteLine("m : " + m);
            Console.WriteLine("p : " + p);

            uint uk=23;
            short s=200,lo= -32768;
            ushort us=90;
            long l=8749274928748738273;
            ulong ul= 8749274928748738273;

            // boolean - true/false

            bool IsAssigned;

            IsAssigned = true;

            Console.WriteLine(IsAssigned);

            // float 

            float kkkk = 0.98F;

            Console.WriteLine("float : " + kkkk);

            // decimal

            decimal jkjk = 9.8M;

            Console.WriteLine("decimal :"+jkjk);

            // byte

            byte[] sample= File.ReadAllBytes(@"C:\Users\ap185229\Desktop\TFSAshish.zip");

            // char

            char sssss = 'j';

            Console.WriteLine("Char : " + sssss);

            //Reference types
            // string, objevt , dynamic

            //string

            // Empty string intilization
            string sampleString = "", s2 = string.Empty ;

            Console.WriteLine("sampleString : "+ sampleString);

            sampleString = Console.ReadLine();

            Console.WriteLine("sampleString : " + sampleString);

            Console.ReadKey();

            //object - compile time

            object Obj = "Some data", obj1 = 1,obj2;

            obj2 = Console.ReadLine();

            Console.WriteLine("obj2"+obj2);

            //dynamic -= run time

            dynamic dyObj; 
        }
    }
}
