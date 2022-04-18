using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14example
{
    internal class Staff : Personnel
    {
        private string work;

        public Staff(string work, string name, int age, string sex, string address) : base(name, age, sex, address)
        {
            this.work = work;
        }

        protected string Work { get => work; set => work = value; }
        public override string ToString()
        {
            return "+ Engineer : " + name + "\n + age : " + age + "\n + gender : " + sex + "\n + address : " + address + "\n + work " + work;
        }
    }
}
