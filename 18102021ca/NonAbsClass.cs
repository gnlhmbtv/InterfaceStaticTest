using System;
using System.Collections.Generic;
using System.Text;

namespace _18102021ca
{
    class NonAbsClass : AbsClass
    {
        public int x { get; set; }
        public int y { get; set; }
        public int sum { get; set; }
        public NonAbsClass(int xvalue, int yvalue)
        {
            x = xvalue;
            y = yvalue;
        }
        public override void Sum()
        {
            sum = x + y;
            Console.WriteLine(sum);
        }
    }
}
