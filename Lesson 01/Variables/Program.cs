using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Переменная - ячейка памяти для хранения информации
             * Шаблон:
             * тип имя = значение;
             * 
             */

            int i = 5;                  // Целочисленная переменная a
            float f = 3.1415f;          // Число с плавающей точкой типа float
            double d = 4.123454;        // Число с плавающей точкой типа double
            char c = '_';               // Символьная переменная c
            string name = "Nikodim";    // Строковая переменная name
            bool b = false;             // Логическая переменная b

            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(name);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
