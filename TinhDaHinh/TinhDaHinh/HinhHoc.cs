using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    public class HinhHoc
    {
        protected int xA260;
        protected int yA260;
        protected int xB260;
        protected int yB260;
        protected int xC260;
        protected int yC260;
        protected int xD260;
        protected int yD260;

        public HinhHoc(int xA260, int yA260, int xB260, int yB260, int xC260, int yC260, int xD260, int yD260)
        {
            this.xA260 = xA260;
            this.yA260 = yA260;
            this.xB260 = xB260;
            this.yB260 = yB260;
            this.xC260 = xC260;
            this.yC260 = yC260;
            this.xD260 = xD260;
            this.yD260 = yD260;
        }

        public virtual void Export()
        {
            
            Console.Write("A({0},{1}) ; B({2},{3}) ; C({4},{5}) ; D({6},{7})", this.xA260, this.yA260, this.xB260, this.yB260, this.xC260, this.yC260, this.xD260, this.yD260);
        }
        public virtual void TinhTien()
        {

        }
    }
}
