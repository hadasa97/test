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
            //Creating the objects
            Dog dog = new Dog(true, true, 0);
            Cat cat = new Cat(true, true, 1);
            Frog frog = new Frog(false, false, 1);

            //Sending objects (dog, cat, frog)to functions
            dog.setMammals(true);
            dog.setCarnivorous(true);
            dog.sayHello();
            dog.sayHello(0);
            dog.sayHello(1);
            if ((dog.getNumberOfLegs())==4)
              Console.WriteLine("Dogs live on land,number of legs is "+ dog.getNumberOfLegs());
            Console.WriteLine();

           
            cat.setMammals(true);
            cat.setCarnivorous(true);
            cat.sayHello();
            cat.sayHello(0);
            cat.sayHello(1);
            Console.WriteLine("number of legs is " + cat.getNumberOfLegs());
            Console.WriteLine();

     
            frog.setMammals(false);
            frog.setCarnivorous(false);
            frog.sayHello(0);
            frog.sayHello(1);
            Console.WriteLine("hasGills?- "+frog.hasGills());
            Console.WriteLine("hasLaysEggs?- "+frog.hasLaysEggs());
            Console.WriteLine("number of legs is " + frog.getNumberOfLegs());
           
            Console.Read();
        }
    }
}
