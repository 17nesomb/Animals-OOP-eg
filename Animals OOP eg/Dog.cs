using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_OOP_eg
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            this.name = name;
        }

        List<string> objects = new List<string> { "ball", "stick", "rabbit" };
        Random r = new Random();

        public void Fetch()
        {
            int index = r.Next(objects.Count);

            Console.WriteLine($"{name} fetched you a {objects[index]}");
        }

        public void Bark()
        {
            Console.WriteLine($"{name} said WOOF");

        }

        public void RollOver()
        {
            Console.WriteLine($"{name} is really dizzy");
        }
    }
}
