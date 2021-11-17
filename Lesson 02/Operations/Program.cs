using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 3;

            Console.WriteLine(a + b);   // Выведет 10
            Console.WriteLine(a - b);   // Выведет 4
            Console.WriteLine(a * b);   // Выведет 21
            Console.WriteLine(a / b);   // Выведет 2
            Console.WriteLine(a % b);   // Выведет 1
            Console.WriteLine(a >> b);   // Выведет 0
            Console.WriteLine(a << b);   // Выведет 56
            Console.ReadKey();
        }
    }
}