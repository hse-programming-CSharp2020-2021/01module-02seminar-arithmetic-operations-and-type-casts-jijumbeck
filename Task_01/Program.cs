/*
 * Задача : 
 * Ввести значение x и вывести значение полинома: F(x) = 12x^4 + 9x^3 - 3x^2 + 2x – 4. 
 * С точностью до 2-х знаков после запятой. 
 * !!! Не применять возведение в степень. !!!
 * Использовать минимальное количество операций умножения. 
 * (Алгоритм быстрого возведения в степень : https://e-maxx.ru/algo/binary_pow)
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1
 * -------test_2-------
 * 0
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 16,00
 * -------test_2-------
 * -4,00
 * --------------------
 * 
 * Тестирование будет проводиться на машинах с английской локалью, где в качестве разделителя в 
 * вещественных числах используется точка. Чтобы выводилась запятая надо принудительно сменить локаль на русскую.
 */

using System;
using System.Globalization;
using System.Threading;

namespace Task_01 {
	class Program {
		static void Main(string[] args) {
			// TODO : Сменить локаль на "ru-RU". 
			Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");

			double x;
			// Ввод данных. 
			x = double.Parse(Console.ReadLine());

			// Вычисление и вывод данных.
			Console.WriteLine($"{Function(x):f2}");

		}

		static double Function(double x) {
			// TODO : Реализовать вычисление функции F(x).
			return 12 * myPow(x, 4) + 9 * myPow(x, 3) - 3 * myPow(x, 2) + 2 * x - 4;
		}

		static double myPow(double x, int pow) {
			// TODO : Реализовать быстрое возведение в степень.
			if (pow == 0)
			{
				return 1;
			}
			else if (pow % 2 == 0)
			{
				double g = myPow(x, pow / 2);
				return g * g;
			}
			else
			{
				return x * myPow(x, pow - 1);
			}
		}
	}
}
