using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_classes
{
    abstract class Animal
    {
        interface IAnimalProperties
        {
            string Name { get; set; }
            string Colour { get; set; }
            int Height { get; set; }
            int Age { get; set; }
        }

        interface IAnimalMethods
        {
            void Eat();
            string Cry();
        }
    }
}
