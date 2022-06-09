using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTask3._1
{
    internal static class Calc
    {
        /// <summary>
        /// Вычисление корней с помощью дискриминанта
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static (double?,double?) QuadEquation(double a,double b,double c)
        {
            double D = Math.Pow(b,2) - 4 * a * c;
            return D >= 0 ? ((-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a)) : (null,null);
        }
    }
}
