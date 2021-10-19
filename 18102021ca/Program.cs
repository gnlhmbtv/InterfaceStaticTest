using System;
using newNamespace;

namespace _18102021ca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interface and Abs Class
            // Shark shark = new Shark();
            // shark.Swim();
            //Fish fish = new Fish();
            //fish.Swim();
            #endregion
            #region Static 
            //Console.WriteLine(StaticClass.Sum(5, 15));
            #endregion
            #region Extension
           // Extension.Power(5, 2);
            #endregion
            #region NameSpace
            SomeClass value = new SomeClass(65);
            Console.WriteLine(value.Return());

            #endregion


        }
    }
}
