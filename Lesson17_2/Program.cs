using System;

namespace MyApp
{
    static class Any
    {
        public static string? Name { get; set; }

        public static void DoSomething() { Console.WriteLine("Test"); }
    }


    class Program
    {
        void Foo()
        {
            Console.WriteLine("Foo");
        }

        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}