using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Cat cat = new Cat();
            bird.fly();
            cat.Run();
            Console.ReadKey();
        }
    }
}
