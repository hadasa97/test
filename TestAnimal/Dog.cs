using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    class Dog : Animal, Land
    {
       private const int numberOfLegs=4;
        public Dog(Boolean mammals, Boolean carmivorous, int mood) : base(mammals, carmivorous, mood)
        {
       
        }

        public int getNumberOfLeg()
        {
            return numberOfLegs;
        }

        public override void sayHello()
        {
            Console.Write("Cats ");
            base.sayHello();
            Console.WriteLine("wagging their tails");

        }
        public override void sayHello(int mood)
        {
            
            base.sayHello(mood);
            if (mood == 0)
                Console.WriteLine(" bark loudly");
            else
                Console.WriteLine(" whooping");

        }

    }
}
