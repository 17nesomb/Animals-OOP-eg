using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_OOP_eg
{
    class Hedgehog : Animal
    {
        public void Squeak()
        {
            Console.WriteLine($"{name} just squeaked at you!");
        }
        public Hedgehog(string name)
        {
            this.name = name;
        }

        public void Hibernate()
        {
            Console.WriteLine($"{name} says ZzzZzzZzZ");
        }
    }
}
