using System;

namespace Farm
{
    class StartUp
    {
            static void Main()
            {
                Dog dog = new Dog();
                dog.Eat();
                dog.Bark();
            }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
}
