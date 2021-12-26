using System;
using System.Diagnostics;

namespace Les3Ex2
{
    //Ронжин Леонид
    //Реализовать метод, который в качестве входного параметра принимает строку string,
    //возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Console.WriteLine("\nHello World! -> " + "Hello World!".ReverseByStringBuilder());  
            stopwatch.Stop();
            Console.WriteLine($"from StringBuilder: {stopwatch.ElapsedTicks} ticks");

            stopwatch.Restart();
            Console.WriteLine("\nHello World! -> " + "Hello World!".ReverseByArray()); 
            stopwatch.Stop();
            Console.WriteLine($"from CharArray: {stopwatch.ElapsedTicks} ticks");

            stopwatch.Restart();
            Console.WriteLine("\nHello World! -> " + "Hello World!".ReverseByLINQ());
            stopwatch.Stop();
            Console.WriteLine($"from LINQ: {stopwatch.ElapsedTicks} ticks");

            Console.ReadKey();
        }
    }
}
