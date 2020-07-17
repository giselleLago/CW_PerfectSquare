using System;

namespace CW_PerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Kata();
            Console.WriteLine(a.FindNextSquare(121));
            Console.ReadKey();
        }
    }
}
