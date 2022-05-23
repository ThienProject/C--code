using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter total number of family in town :  ");
           int totalFamily_260 = int.Parse(Console.ReadLine());

            Town town_260 = new Town();
            
           for(int i = 0; i < totalFamily_260; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("- Enter Infor Family :"+ (i+1));
                Console.Write("     Enter Address:");
                string address_260 = Console.ReadLine();
                Console.Write("     Enter the number of family members :");
                int totalPerson_260 = int.Parse(Console.ReadLine());

                List<Person> persons = new List<Person>();
                for(int j = 0; j < totalPerson_260; j++)
                {
                   
                    Console.WriteLine("     ------- Member " + (j+1)+"-------");
                    Console.Write("     Enter Name : ");
                    string name_260 = Console.ReadLine();
                    Console.Write("     Enter Age : ");
                    int age_260 = int.Parse(Console.ReadLine());
                    Console.Write("     Enter JOB : ");
                    string job_260 = (Console.ReadLine());
                    Console.Write("     Enter Identity Card : ");
                    int identityCard_260 = int.Parse((Console.ReadLine()));
                    Person person_260 = new Person(name_260, age_260, job_260, identityCard_260);
                    persons.Add(person_260);
                }    
                Family family = new Family(address_260, persons);
                town_260.addFamily(family);

            }
            exportTown(town_260);
        }
     

        public static void exportTown(Town town)
        {
            for(int i = 0; i< town.Families_260.Count; i++)
            {
                Console.WriteLine(town.Families_260[i].toString(i + 1));
            }
            Console.ReadKey();
        }
    }
}
