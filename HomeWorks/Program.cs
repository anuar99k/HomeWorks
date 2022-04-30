using System;
using System.Text;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Задача #1:");
            Console.WriteLine("Введите сторону прямоугольника А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата С: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (c < a && c < b)
            {
                // кол-во вмещаемых квадратов
                int numberOfSquares = a * b / (int) Math.Pow(c, 2); // возведение в степень: Math.Pow(число, степень)
                Console.WriteLine($"Количество квадратов: {numberOfSquares}");
                Console.WriteLine($"Площадь незанятой части: {a * b - numberOfSquares * Math.Pow(c, 2)}");
            }
            else
            {
                Console.WriteLine($"В прямоугольнике нельзя разместить ни одного квадрата со стороной: {c}");
            }

            Console.WriteLine("Задача #2:");
            double p, s;
            Console.WriteLine("Введите проценты P: ");
            p = Convert.ToDouble(Console.ReadLine());
            a = 0; // 0 вместо 1
            s = 10000;
            while(s<=11000)
            {
                s += (s * p) / 100;
                a++;
            }
            Console.WriteLine($"Сумма {s} станет через {a} месяцев");

            Console.WriteLine("Задача #3:");
            Console.WriteLine("Введите число А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число В: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задача #4:");
            Console.WriteLine("Введите число: ");
            string str = Console.ReadLine();
            char [] array = str.ToCharArray();
            Array.Reverse(array);
            
            // Данная строчка выведет тип переменной array (System.Char[]), вместо его содержимого
            // Console.WriteLine($"Ваше число в обратном порядке: {array}");
            // подробнее: https://stackoverflow.com/questions/65590304/why-console-writeline-outputs-text-without-a-format-string-and-the-type-name-whe
            
            // для вывода содержимого массива array, нужно преобразовать его в тип string:
            Console.WriteLine($"Ваше число в обратном порядке: {new string(array)}");
            // либо так:
            Console.WriteLine($"Ваше число в обратном порядке: {string.Concat(array)}");
            // статический метод Concat, определённый в типе string, конкатенирует символы
            // и возвращает результирующую строку
        }
    } 
}