using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Manager
{
    internal class Town
    {
        private List<Family> families_260;

        public Town()
        {
            families_260 = new List<Family>();
        }
        public Town(List<Family> families_260)
        {
            this.families_260 = families_260;
        }
        public void addFamily(Family family)
        {
            this.families_260.Add(family);
        }
        internal List<Family> Families_260 { get => families_260; set => families_260 = value; }
    }
}
