using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Manager
{
    internal class Family
    {
        protected string address_260;
        protected List<Person> persons_260;

        public string Address_260 { get => address_260; set => address_260 = value; }
        public List<Person> Persons_260 { get => persons_260; set => persons_260 = value; }

        public Family(string address_260, List<Person> persons_260)
        {
            this.address_260 = address_260;
            this.persons_260 = persons_260;
        }
        public string toString(int index)
        {
            string string_260 = "\n Famyli " + index + "(   \n member : ";
            int count_260 = 1;
            foreach(Person person in this.persons_260)
            {
                string_260 += person.toString(count_260);
                count_260++;
            }
            string_260 += " address : "+address_260 +")";
            return string_260;
        }
    }
}
