/*
 * Задача : 
 * Получить от пользователя четырехзначное натуральное число 
 * и напечатать его цифры в обратном порядке.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1234
 * -------test_2-------
 * 5669
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4321
 * -------test_2-------
 * 9665
 * --------------------
 */

using System;
using System.Text;

namespace Task_4
{
    class Program
    {
        const int countOfDigits = 4;
        static void Main(string[] args)
        {
            int x;
            // TODO : Считать целочисленное значение.
            x = int.Parse(Console.ReadLine());

            // TODO : Вычислить значение и вывести.
            Console.WriteLine(ReverseNumber(x));
        }

        static int ReverseNumber(int x)
        {
            // Предлагается 2 решения данной задачи : 
            // 1) Выделить каждую цифру в отдельную переменную и собрать их в обратном порядке.
            // 2) Преобразовать переменную в строку использовать метод Reverse и выполнить обратное преобразование.
            // Выбор метода остаётся за вами.

            int[] digits = new int[countOfDigits];
            for (int i = 0; i < countOfDigits; i++)
            {
                digits[i] = x % 10;
                x /= 10;
            }
            int number = 1;
            int result = 0;
            for (int i = 0; i < countOfDigits; i++)
            {
                result += digits[countOfDigits - 1 - i] * number;
                number *= 10;
            }
            return result;

        }
    }
}
