using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class Triangle : HinhHoc
    {
        public Triangle(int xA260, int yA260, int xB260, int yB260, int xC260, int yC260, int xD260, int yD260) : base(xA260, yA260, xB260, yB260, xC260, yC260, xD260, yD260)
        {

        }
        public override void Export()
        {
            Console.WriteLine("Triangle : ");
            Console.Write("A({0},{1}) ; B({2},{3}) ; C({4},{5}) ", this.xA260, this.yA260, this.xB260, this.yB260, this.xC260, this.yC260);

        }
    }
}
