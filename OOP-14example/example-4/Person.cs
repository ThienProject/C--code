using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Manager
{
    internal class Person
    {
        protected string name;
        protected int age;
        protected string job;
        protected int identityCard;

        public Person(string name, int age, string job, int identityCard)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            this.identityCard = identityCard;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int IdentityCard { get => identityCard; set => identityCard = value; }
        public string Job { get => job; set => job = value; }

        public string toString(int index)
        {
            return "\n      Person "+ index + "{ name: " + this.name + " age: " + this.age + " job: " + this.job + " identity card: " + this.identityCard + "}";
        }
        
    }
}
