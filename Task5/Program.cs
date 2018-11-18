using System;

namespace Task5
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Derived.field++;
            Console.WriteLine(Found.field);
            Console.ReadKey();
        }
    }
}
