using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    class Frog:Animal,Water
    {
        public Frog(Boolean mammals, Boolean carmivorous, int mood) : base(mammals, carmivorous, mood)
        {

        }

        public bool hasGills()
        {
            return true;
        }

        public bool hasLayerEggs()
        {
            return true;
        }

        public override void sayHello()
        {
            Console.Write("Cats ");
            base.sayHello();
            Console.WriteLine("wagging their tails");

        }

    }
}
