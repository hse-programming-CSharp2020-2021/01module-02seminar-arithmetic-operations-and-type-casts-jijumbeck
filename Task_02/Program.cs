/*
 * Задача : 
 * Ввести натуральное трехзначное число Р. 
 * Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 208
 * -------test_2-------
 * 159
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 820
 * -------test_2-------
 * 951
 * --------------------
 */

using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            // TODO : Реализовать ввод целочисленного значения.
            p = int.Parse(Console.ReadLine());

            // TODO : Посчиать и вывести результат.
            Console.WriteLine(MaxPermutation(p));
        }

        static int MaxPermutation(int x)
        {
            // TODO : Получить цифры числа используя арифметические операции.
            int firstDigit = x % 10,
                secondDigit = (x % 100) / 10,
                thirdDigit = x / 100;

            // TODO : Собрать новое число и вернуть его. 
            int max = GetMax(firstDigit, secondDigit, thirdDigit) * 100 + 
                GetMiddle(firstDigit, secondDigit, thirdDigit) * 10 + GetMin(firstDigit, secondDigit, thirdDigit);

            return max;
        }

        static int GetMax(int a, int b, int c)
        {
            if(a > b && a > c)
            {
                return a;
            }
            else if(b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        static int GetMiddle(int a, int b, int c)
        {
            if ((a > b && a < c)  || (a < b && a > c))
            {
                return a;
            }
            else if ((b > a && b < c) || (a > b && b > c))
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        static int GetMin(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
