using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14example
{
    internal class Personnel
    {
        protected string name;
        protected int age;
        protected string sex;
        protected string address;

        public Personnel(string name, int age, string sex, string address)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.address = address;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }


    }
}

