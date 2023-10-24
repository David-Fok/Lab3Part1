using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public short Age { get; set; }

        public Animal() { }
        public abstract void Eat();
    }
}
