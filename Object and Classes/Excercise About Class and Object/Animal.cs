using System;

namespace Excercise_About_Class_and_Object
{
    interface IAnimal
    {
        public void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class Pig : IAnimal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();

            myPig.sleep();
            myPig.animalSound();
        }
    }
}
