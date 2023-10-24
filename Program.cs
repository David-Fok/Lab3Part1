using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog dog1 = new Dog("Peter", "Black", 2);
            dog1.Eat();

            Cat cat1 = new Cat("Angel", "Black", 5);
            cat1.Eat();
        }
    }
}