using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    class Dog : Animal, Land
    {
        //constant variable
       private const int numberOfLegs=4;
       
        //Sending to base builder
        public Dog(Boolean mammals, Boolean camivorous, int mood) : base(mammals, camivorous, mood)
        {
       
        }
        //Returning number of animal legs, using the interface
       
       public int getNumberOfLegs()
        {
            return numberOfLegs;
        }

       //Saying hello and reaction , using base class too
        public override void sayHello()
        {
            
            base.sayHello();
            Console.WriteLine("wagging their tails");

        }

        public override void sayHello(int mood)
        {
            
            base.sayHello(mood);
            if (mood == 0)
                Console.WriteLine(" barking loudly");
            else
                Console.WriteLine(" whooping sound");

        }

    }
}
