using System;
using System.Collections.Generic;
using System.Text;

namespace _18102021ca
{
    static class Extension
    {
        public static void Power(this double num, double pow)
        {
            double result;
            result = Math.Pow(num, pow);
            Console.WriteLine(result);
        }
    }
}
