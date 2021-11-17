using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {

            // Форматирование строк
            //
            // Вариант 1
            //
            // Существует такая операция, как конкатенация строк (сложение)
            // c = a + b = ab
            //
            // Пример

            string firstName = "Владимир";
            string lastName = "Ленин";
            string specialization = "Революционер";

            int yearOfBirth = 1870;
            int yearOfDeath = 1924;

            // ВладимирЛенинРеволюционер18701924
            Console.WriteLine(firstName + lastName + specialization + yearOfBirth + yearOfDeath);
            Console.ReadKey();

            // В данном случае, мы получим слипшуюся строку.
            // Чтобы избежать этого, можно добавлять строку с пробелом между 
            // всеми параметрами.
            // 
            // Пример

            // Владимир Ленин Революционер 1870 1924
            Console.WriteLine(firstName + " " + lastName + " " + specialization + " " + yearOfBirth + " " + yearOfDeath);
            Console.ReadKey();

            // Для большей наглядности можно выводить и некоторые строки,
            // чтобы, например, подписать параметры.
            // 
            // Пример

            // Имя: Владимир, Фамилия: Ленин, Специализация: Революционер, Год рождения: 1870, Год смерти: 1924
            Console.WriteLine("Имя: " + firstName + ", Фамилия: " + lastName + ", Специализация: " + specialization + ", Год рождения: " + yearOfBirth + ", Год смерти: " + yearOfDeath);
            Console.ReadKey();

            // Чтобы постоянно не выполнять конкатенацию строк,
            // а делать всё в одной строке, только подставляя значения переменных,
            // используется форматирование строки. Есть несколько вариантов.

            // Первый способ 
            // Первый способ заключается в том, что мы на места,
            // где должны быть подставлены переменные, ставятся индексы
            // в фигурных скобках. Сами переменные указываются через
            // запятую после строки.
            // 
            // Пример

            // Имя: Владимир, Фамилия: Ленин, Специализация: Революционер (1870 – 1924)
            Console.WriteLine("Имя: {0}, Фамилия: {1} Специализация: {2} ({3} – {4})",
                                           firstName,
                                           lastName,
                                           specialization,
                                           yearOfBirth,
                                           yearOfDeath);
            Console.ReadKey();

            // Второй способ 
            // Также можно создать строковую переменную с такими же индексами,
            // переменные перечисляются аналогично первому способу

            // Имя: Владимир, Фамилия: Ленин, Специализация: Революционер (1870 – 1924)

            string pattern = "Имя: {0}, Фамилия: {1} Специализация: {2} ({3} – {4})";
            Console.WriteLine(pattern,
                                firstName,
                                lastName,
                                specialization,
                                yearOfBirth,
                                yearOfDeath);
            Console.ReadKey();

            // Третий способ
            // Более удобным и компакным способом является интерполяция строк.
            // Эта функция доступна, начиная с версии языка C# 6.0.
            // Эта функциональность призвана заменить форматирование строк.
            // Знак доллара перед строкой указывает, что будет осуществляться
            // интерполяция строк. Внутри строки опять же используются
            // плейсхолдеры {...}, только внутри фигурных скобок уже пишутся
            // не индексы, а те выражения, которые мы хотим вывести.


            // Революционер Владимир Ленин (1870 – 1924, 54 года)

            Console.WriteLine($"{specialization} {firstName} {lastName} ({yearOfBirth} – {yearOfDeath}, {yearOfDeath - yearOfBirth} года)");
            Console.ReadKey();

            // Интерполяция по сути представляет более лаконичное форматирование.
            // При этом внутри фигурных скобок мы можем указывать не только свойства,
            // но и различные выражения языка C#.



            // Управляющие последовательности
            // Управляющие последовательности - это постоянные значения,
            // которые выполняют определённую функцию.

            Console.WriteLine("\a");
            Console.WriteLine("\b");
            Console.WriteLine("\f");
            Console.WriteLine("\n");
            Console.WriteLine("\r");
            Console.WriteLine("\t");
            Console.WriteLine("\v");
            Console.WriteLine("\0");
            Console.WriteLine("\'");
            Console.WriteLine("\\");

            Console.ReadKey();

            // Например, если нам нужно перенести текст на новую строку,
            // мы добавляем `\n`в месте разрыва строки

            // Революционер Владимир Ленин
            // (1870 – 1924, 54 года)

            Console.WriteLine($"{specialization} {firstName} {lastName}\n({yearOfBirth} – {yearOfDeath}, {yearOfDeath - yearOfBirth} года)");
            Console.ReadKey();
        }
    }
}