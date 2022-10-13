using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public virtual void eat()
        {

            Console.WriteLine("Animals eat food.");
        }
    }

    // derived class of Animal 
    class Cat : Animal
    {

        // overriding method from Animal
        public override void eat()
        {

            // call method from Animal class
            base.eat();

            Console.WriteLine("Cats eat Cat food.");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Cat labrador = new Cat();
            labrador.eat();
        }
    }
}
/*
Output:
Animals eat food.
Cats eats Cat food.
*/