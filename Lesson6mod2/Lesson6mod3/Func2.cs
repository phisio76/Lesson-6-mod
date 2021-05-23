using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6mod3
{
    class Func2
    {
        public static double Sum(double x)
        {
            return 3 * x * x;
        }
        public static double linear(double x)
        {
            return 2 * x + 3;
        }
        public static double Squaring(double x)
        {
            return x * x;
        }
        public static double Cubing(double x)
        {
            return x * x * x;
        }
        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        public static double Sin(double x)
        {
            return Math.Sin(x);
        }
    }
}
