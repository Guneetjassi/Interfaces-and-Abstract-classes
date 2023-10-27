using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a dog's name: ");
            string dogName = Console.ReadLine();

            Dog dog = new Dog();
            dog.Name = dogName;

            Console.Write("Enter the dog's height (in inches or centimeters): ");
            int dogHeight = int.Parse(Console.ReadLine());

            Console.Write("Enter the dog's colour: ");
            dog.Colour = Console.ReadLine();

            Console.Write("Enter the dog's age: ");
            dog.Age = int.Parse(Console.ReadLine());


            Console.WriteLine($"Dog's Name: {dog.Name}");
            Console.WriteLine($"Dog's Height: {dog.Height}");
            Console.WriteLine($"Dog's Colour: {dog.Colour}");
            Console.WriteLine($"Dog's Age: {dog.Age}");

            dog.Eat();
            Console.WriteLine($"Dog says: {dog.Cry()}");

            Console.Write("Enter a cat's name: ");
            string catName = Console.ReadLine();

            Cat cat = new Cat();
            cat.Name = catName;

            Console.Write("Enter the cat's height: ");
            cat.Height = int.Parse(Console.ReadLine());

            Console.Write("Enter the cat's colour: ");
            cat.Colour = Console.ReadLine();

            Console.Write("Enter the cat's age: ");
            cat.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cat's Name: {cat.Name}");
            Console.WriteLine($"Cat's Height: {cat.Height}");
            Console.WriteLine($"Cat's Colour: {cat.Colour}");
            Console.WriteLine($"Cat's Age: {cat.Age}");

            cat.Eat();
            Console.WriteLine($"Cat says: {cat.Cry()}");
        }
    }
}