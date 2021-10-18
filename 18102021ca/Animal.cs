using System;
using System.Collections.Generic;
using System.Text;

namespace _18102021ca
{
   abstract class Animal
    {
        public abstract void Eat();
        public abstract void Sleep();
        public virtual void Move()
        {
            Console.WriteLine("Move as animal");
        }
    }
     sealed class Fish 
    {
        public  void Swim()
        {
            Console.WriteLine("Swim as fish");
        }
        
        
    }
   /* class Shark : Fish,IRunable
    {
        public override void Eat()
        {
            Console.WriteLine("eat as shark");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep as shark");  
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as shark");
        }
        
    }*/
}
