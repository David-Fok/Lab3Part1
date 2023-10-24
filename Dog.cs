using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog : Animal
    {
        public Dog(string name, string colour, short age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }
        public override void Eat()
        { Console.WriteLine("Dogs eat meat."); }
    }
}
