using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
               int xA260;
               int yA260;
               int xB260;
                int yB260;
                int xC260;
                int yC260;
                int xD260;
                int yD260;

            

            while (true)
            {
                int select260;
                Console.WriteLine();
                Console.WriteLine("---------------------------------new----------------");
                Console.WriteLine("Enter geometry : ");
                Console.WriteLine("1 : Retange");
                Console.WriteLine("2 : Quadrilateral");
                Console.WriteLine("3 : Triangle");
                Console.WriteLine("0 : Exit");
                select260 = int.Parse(Console.ReadLine());
                switch (select260)
                {
                    case 1:
                        Console.WriteLine("Nhap toa do A, B,C, D");
                        xA260 = int.Parse(Console.ReadLine());
                        yA260 = int.Parse(Console.ReadLine());
                        xB260 = int.Parse(Console.ReadLine());
                        yB260 = int.Parse(Console.ReadLine());
                        xC260 = int.Parse(Console.ReadLine());
                        yC260 = int.Parse(Console.ReadLine());
                        yD260 = int.Parse(Console.ReadLine());
                        xD260 = int.Parse(Console.ReadLine());
                        HinhHoc retange = new Retange(xA260, yA260, xB260, yB260, xC260, yC260, xD260, yD260);
                        retange.Export();
                        break;

                    case 2:
                        Console.WriteLine("Nhap toa do A, B,C, D");
                        xA260 = int.Parse(Console.ReadLine());
                        yA260 = int.Parse(Console.ReadLine());
                        xB260 = int.Parse(Console.ReadLine());
                        yB260 = int.Parse(Console.ReadLine());
                        xC260 = int.Parse(Console.ReadLine());
                        yC260 = int.Parse(Console.ReadLine());
                        yD260 = int.Parse(Console.ReadLine());
                        xD260 = int.Parse(Console.ReadLine());
                        HinhHoc Quadrilateral = new Quadrilateral(xA260, yA260, xB260, yB260, xC260, yC260, xD260, yD260);
                        Quadrilateral.Export();
                        break ;
                    case 3:
                        Console.WriteLine("Nhap toa do A, B,C");
                        xA260 = int.Parse(Console.ReadLine());
                        yA260 = int.Parse(Console.ReadLine());
                        xB260 = int.Parse(Console.ReadLine());
                        yB260 = int.Parse(Console.ReadLine());
                        xC260 = int.Parse(Console.ReadLine());
                        yC260 = int.Parse(Console.ReadLine());
  
                        HinhHoc triangle = new Triangle(xA260, yA260, xB260, yB260, xC260, yC260,0,0);
                        triangle.Export();
                        break;
                    case 0: return;
                    default: Console.WriteLine("Invalid");continue;
                } 
              
                    

            }
           
            Console.ReadKey();
        }
    }
}
