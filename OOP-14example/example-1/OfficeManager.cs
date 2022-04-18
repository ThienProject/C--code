using OOP_14example;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1
{
    internal class OfficeManager
    {
        private List<Personnel> personnels;

 
        public OfficeManager()
        {
            this.personnels = new List<Personnel>();
        }

        public void addPersonnel(Personnel personnel)
        {
            this.personnels.Add(personnel);
        }

        public List<Personnel> findPersonnnelsByName(string name)
        {
            List<Personnel> personnelList = new List<Personnel>();
            foreach (var pi in this.personnels)
            {
               if(pi.Name.Contains(name))
                {
                    personnelList.Add(pi);
                }
            }
            return personnelList;
        }
        public void showListPersonnel()
        {
            foreach (var pi in this.personnels)
            {
                Console.WriteLine(pi.ToString());
            }
        }
    } 
}

