// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с 
// консоли. Программа завершается при вводе символа ‘q’ или при вводе числа,
//  сумма цифр которого четная.
 
//  Пример
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

using System;

namespace EvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("Введите целое число:");
                input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                int number;
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Неверный ввод. Введите целое число.");
                    continue;
                }

                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                if (sum % 2 == 0)
                {
                    Console.WriteLine("Сумма цифр числа {0} четная.", input);
                    break;
                }
            } while (true);

            Console.WriteLine("STOP.");
        }
    }
}