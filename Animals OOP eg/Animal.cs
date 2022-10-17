using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_OOP_eg
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine($"{name} just ate something!");
        }

        public string name;

        public int hunger;
    }
}
