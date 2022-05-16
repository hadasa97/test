using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnimal
{
    public enum mood
    {
        MOOD_HAPPY,
        MOOD_SCARE
    }
     abstract class Animal
    {
        public Boolean mammals { get; set; }
        public Boolean carmivorous { get; set; }

        public mood mood;

        public Animal(Boolean mammals, Boolean carmivorous, int mood)
        {
            this.mammals = mammals;
            this.carmivorous = carmivorous;
            this.mood = (mood)mood;
        }
        public virtual void sayHello()
        {
            Console.Write("greet people by ");
        }

        public virtual void sayHello(int mood)
        {
           Console.Write("When the mood "+ (mood)mood);
            
        }
        public  Boolean isMammals()
        {
            return this.mammals;
        }

        public void setMammals(Boolean mammals)
        {
            //this.mammals = mammals;
            Console.WriteLine(isMammals());
        }





    }
}
