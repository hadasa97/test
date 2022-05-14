using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    class Cat:Animal
    {
        public Cat(Boolean mammals, Boolean carmivorous, int mood) : base(mammals, carmivorous, mood)
        {

        }

       
        public override void sayHello()
        {
            Console.Write("Dogs ");
            base.sayHello();
            Console.WriteLine("meow");

        }
    }
}
