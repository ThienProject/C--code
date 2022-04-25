using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    internal class Retange:HinhHoc
    {
        public Retange(int xA260, int yA260, int xB260, int yB260, int xC260, int yC260, int xD260, int yD260) : base(xA260, yA260, xB260, yB260, xC260, yC260, xD260, yD260)
        {
            
        }
        public override void Export()
        {
            Console.WriteLine("Retange : ");
            base.Export();
        }

    }
}
