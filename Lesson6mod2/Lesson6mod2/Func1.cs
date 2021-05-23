using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6mod2
{
    class Func1
    {
        public static double MyFunc(double a, double x) // Метод возвращает  a*x^2
        {
            return a * x * x;
        }

        public static double MySin(double a, double x) // Метод возвращает  a*sin(x)
        {
            return a * Math.Sin(x);
        }
    }
}
