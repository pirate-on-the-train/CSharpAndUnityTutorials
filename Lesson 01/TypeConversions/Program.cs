using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Явное преобразование (просто переменная получает значение другой переменной)
            int n1 = 2021;
            long n2 = n1;
            Console.WriteLine(n2);       // Выведет 2021

            // 
            // Неявное преобразование
            // 
            // Шаблон
            // (тип)переменная
            // 
            float pi = 3.1415f;
            int a = (int)pi;
            Console.WriteLine(a);       // Выведет 3 (обрежет дробную часть)

            // Перевод строковых переменных
            // 
            // Шаблон
            // (тип).Parse(переменная)
            // 
            string year = "2021";
            int yearInt = int.Parse(year);
            Console.WriteLine(year + 5);            // Выведет 20215
            Console.WriteLine(yearInt + 5);         // Выведет 2026
        }
    }
}
