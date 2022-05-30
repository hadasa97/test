using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    //Creating enum for animal mood
    public enum mood
    {
        MOOD_HAPPY,
        MOOD_SCARE
    }

    //Creating an abstract class for the animal structure
    abstract class Animal
    {
        public Boolean mammals { get; set; }
        public Boolean carnivorous { get; set; }

        public mood mood;

        //Creating a class builder
        public Animal(Boolean mammals, Boolean carmivorous, int mood)
        {
            this.mammals = mammals;
            this.carnivorous = carmivorous;
            this.mood = (mood)mood;
        }
        //Say hello function
        public virtual void sayHello()
        {
            Console.Write(this.GetType().Name + " greet people by ");
        }

        //Reaction of the animals in different moods
        public virtual void sayHello(int mood)
        {
            Console.Write("When their mood " + ((mood)mood) + "-");

        }
        //Attributes 
        public Boolean isMammals()
        {
            return this.mammals;
        }

        public void setMammals(Boolean mammals)
        {
            Console.Write(this.GetType().Name);
            if ((isMammals()) == true)
                Console.WriteLine("s are mammalian");
            else

                Console.WriteLine("s are not mammalian");
        }

        public Boolean isCarnivorous()
        {
            return this.mammals;
        }

        public void setCarnivorous(Boolean mammals)
        {
            Console.Write(this.GetType().Name);
            if ((isMammals()) == true)
            {
                Console.WriteLine("s are carnivorous");
            }
            else
            {
                Console.WriteLine("s are not carnivorous");
            }
        }

    }
}
