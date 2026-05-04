using System;
using LAB03;
namespace LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1.1 (Код проверки пишем ниже)
            Rational r1 = new Rational(3, 8);
            Console.WriteLine($"1.1 (3, 8) = {r1}");

            // Задание 1.2 (Код проверки пишем ниже)
            Rational r2 = new Rational(4);
            Console.WriteLine($"1.2 (4) = {r2}");
            // Задание 1.3 (Код проверки пишем ниже)
            Rational r3 = new Rational();
            Console.WriteLine($"1.3  = {r3}");

            // Задание 1.4 (Код проверки пишем ниже)
            Console.WriteLine("1.4 Проверка знаменателя 0:");
            try
            {
                Rational r4 = new Rational(-3, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


            // Задание 2.1 (Код проверки пишем ниже)
            Rational r5 = new Rational(4, 8);
            Console.WriteLine($"\n2.1 = {r5}");

            // Задание 2.2 (Код проверки пишем ниже)
            Rational r6 = new Rational(4, -9);
            Console.WriteLine($"2.2 (4, -9) = {r6}");
            Rational r7 = new Rational(-2, -10);
            Console.WriteLine($"2.3 (-2, -10) = {r7}");

            // Задание 3.1 (Код проверки пишем ниже)
            Console.WriteLine("\n 3.1");
            Console.WriteLine(r1 + r6);
            Console.WriteLine(r1 * r2);
            Console.WriteLine(r1 / r5);
            Console.WriteLine(r1 - r5);

            // Задание 3.2 (Код проверки пишем ниже)
            Console.WriteLine("3.2");
            Console.WriteLine(r6 != r5);
            Console.WriteLine(r1 == r3);
        }
    }
}