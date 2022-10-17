using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_OOP_eg
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog John = new Dog("John the dog");
            Hedgehog Brian = new Hedgehog("Brian the hedgehog");


            John.Eat();
            for (int i = 0; i < 100; i ++)
            {
                John.Fetch();
            }
            John.Bark();
            John.RollOver();

            Brian.Eat();
            Brian.Squeak();
            Brian.Hibernate();
        }
    }
}
