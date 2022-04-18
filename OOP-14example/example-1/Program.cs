using OOP_14example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "", gender ="", address="";
            int age = 0;
            

            OfficeManager officeManager260s = new OfficeManager();
            while (true)
            {
                Console.WriteLine("------------- new action -----------------------");
                Console.WriteLine("Enter 1 : Insert Personnel");
                Console.WriteLine("Enter 2 : Search Personnel by name");
                Console.WriteLine("Enter 3 : Show Personnels");
                Console.WriteLine("Enter 4 : Exit");
                int num260 = int.Parse(Console.ReadLine());

                if(num260 == 1)
                {
                    Console.Write("Enter name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter age : ");
                    age = int.Parse(Console.ReadLine());
                    Console.Write("Enter gender : ");
                    gender = Console.ReadLine();
                    Console.Write("Enter address : ");
                    address = Console.ReadLine();
                }
                switch (num260)
                {
                    
                    case 1:
                        Console.WriteLine("Enter role : ");
                        Console.WriteLine("     . Enter a if it is an Engineer");
                        Console.WriteLine("     . Enter b if it is a Worker");
                        Console.WriteLine("     . Enter c if it is a Staff");
                        char type260 = char.Parse(Console.ReadLine());
                        switch (type260)
                        {
                            case 'a':
                                Console.WriteLine("Enter Tranning industry");
                                string industry = Console.ReadLine();
                                Personnel enggineer = new Engineer(name, age, gender, address, industry);
                                officeManager260s.addPersonnel(enggineer);
                                Console.WriteLine(enggineer.ToString());
                                break;
                            case 'b':
                                Console.WriteLine("Enter tier");
                                int tier = int.Parse(Console.ReadLine());
                                Personnel worker = new Worker(name, age, gender, address, tier);
                                officeManager260s.addPersonnel(worker);
                                Console.WriteLine(worker.ToString());
                                break;
                            case 'c':
                                Console.WriteLine("Enter task");
                                string task = (Console.ReadLine());
                                Personnel Staff = new Staff(task, name, age, gender, address);
                                officeManager260s.addPersonnel(Staff);
                                Console.WriteLine(Staff.ToString());
                                break;
                            default:
                                Console.WriteLine("Invalid");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("=====================================");
                        Console.WriteLine("Enter name to find : ");
                        string nameFind = Console.ReadLine();
                        foreach (var personnel in officeManager260s.findPersonnnelsByName(nameFind)){
                            Console.WriteLine(personnel.ToString());
                        }
                        break;
                    case 3:
                        officeManager260s.showListPersonnel();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid");
                        continue;
                }
                    
            }
            Console.ReadKey();
        }
    }
}
