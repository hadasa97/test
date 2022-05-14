using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(true, true, 0);
            Cat cat = new Cat(false, false, 1);
            dog.setMammals(true);
            cat.setMammals(false);
            ///////List
            // List<Dog> dogs = new List<Dog>();
            // dogs[0] = new Dog(true, true, 0);
            //for (int i=0; i<dogs.Count();i++)
            // {
            //     dogs[i].sayHello();
            // }

            dog.sayHello();
            cat.sayHello();
            dog.sayHello(0);
            dog.sayHello(1);
            Console.Read();
        }
    }
}
