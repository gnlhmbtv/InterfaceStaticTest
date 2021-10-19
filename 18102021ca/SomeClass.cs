using System;
using System.Collections.Generic;
using System.Text;

namespace newNamespace
{
    class SomeClass
    {
        public int num { get; set; }
        public SomeClass(int num)
        {
            this.num = num;
        }
        public int Return()
        {
            return num*2;
        }
    }
}
