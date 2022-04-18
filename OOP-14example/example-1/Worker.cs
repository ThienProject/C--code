using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14example
{
    internal class Worker  : Personnel
    {
        private int tier;

        public Worker( string name, int age, string sex, string address, int tier) : base(name, age, sex, address)
        {
            this.tier = tier;
        }

        protected int Tier { get => tier; set => tier = value; }
        public override string ToString()
        {
            return "+ Worker : " + name + "\n + age : " + age + "\n + gender : " + sex + "\n + address : " + address + "\n + tier " + tier;
        }
    }
}
