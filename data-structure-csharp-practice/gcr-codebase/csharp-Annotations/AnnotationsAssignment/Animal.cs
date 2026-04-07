using System;
using System.Collections.Generic;
using System.Text;

namespace AnnotationsAssignment
{
    internal class Animal
    {

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal obj = new Dog();
            obj.MakeSound();
        }
    }
}
