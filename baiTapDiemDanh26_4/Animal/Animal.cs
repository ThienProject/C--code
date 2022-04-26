using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        public void eat()
        {
            Console.WriteLine("Animal eat");
        }
        public void makeSound(){
            Console.WriteLine("Animal make Sound");
        }
    }
}
