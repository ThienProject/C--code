using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14example
{
    internal class Engineer : Personnel
    {
        private string industry;

        public Engineer( string name, int age, string sex, string address ,string industry) : base(name, age, sex, address)
        {
            this.industry = industry;
        }

        public string Gender { get; }
        protected string Industry { get => industry; set => industry = value; }

        public override string ToString()
        {
            return "+ Engineer : " + name + "\n + age : " + age + "\n + gender : " + sex + "\n + address : " + address + "\n + Traning industry " + industry;
        }
    }
}
