using System;

namespace Lesson6mod2
{


    public delegate double Fun(double a, double x);

    class Program
    {              

        static void Main()
        {

            Console.WriteLine("Таблица функции a*x^2:"); // По взрослому не выходит.,
            Table1.Table(delegate (double a, double x) { return a * x * 2; }, -2.5, -2, 2); // поскольку в Table( ( x ⇒  x * x; }, -2, 2); пишет недопустимый знак: ⇒

            Console.WriteLine("Таблица функции, альтернативный вариант a*x^2:");
            Table1.Table(new Fun(Func1.MyFunc), -2.5, -2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table1.Table(new Fun(Func1.MyFunc), 3, -2, 2);


            Console.ReadKey();
        }
    }
}


