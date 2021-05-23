// Дмитрий Павлов
// 1.Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
// типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и
// функцией a*sin(x).

// 2. Модифицировать программу нахождения минимума функции так, чтобы можно было
// передавать функцию в виде делегата.
// а) Сделать меню с различными функциями и представить пользователю выбор, для какой
// функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов,
// в котором хранятся различные функции.


using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Lesson6mod3
{
    public delegate double Fun(double x);

    class Program
    {                                 

        static void Main(string[] args)
        {
            List<Fun> functions = new List<Fun> { new Fun(Func2.Sum), new Fun(Func2.linear), new Fun(Func2.Squaring), new Fun(Func2.Cubing), new Fun(Func2.Sqrt), new Fun(Func2.Sin) };
            Console.WriteLine("Выберите номер функции.");
            Console.WriteLine("1. f(x)=a*x^2");
            Console.WriteLine("1. f(x)=k*x+b");
            Console.WriteLine("1. f(x)=y^2");
            Console.WriteLine("2. f(x)=y^3");
            Console.WriteLine("3. f(x)=y^1/2");
            Console.WriteLine("4. f(x)=Sin(y)");
            int Choose = Get.GetInt(functions.Count);

            Console.WriteLine("Для нахождения минимума введите отрезок в формате х1 х2:");

            double start = 0;
            double end = 0;
            Get.GetInterval(out start, out end);

            Console.WriteLine("Введите размер шага:");
            double step = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Get.SaveFunc("data.bin", start, end, step, functions[Choose - 1]);
            double min = double.MaxValue;
            Console.WriteLine("Получены следующие значения функции: ");
            Table2.Table(start, end, step, Get.Load("data.bin", out min));
            Console.WriteLine("Минимальное значение функции: {0:0.00}", min);
            Console.ReadKey();
        }
    }
}
