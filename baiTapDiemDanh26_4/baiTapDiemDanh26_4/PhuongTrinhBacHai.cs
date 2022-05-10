using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTapDiemDanh26_4
{
    internal class PhuongTrinhBacHai
    {
        private double a260;
        private double b260;
        private double c260;
        private double DELTA_260;
        private double x260;
        private double x1260;
        private double x2260;
        protected double A260 { get => a260; set => a260 = value; }
        protected double B260 { get => b260; set => b260 = value; }
        protected double C260 { get => c260; set => c260 = value; }

        public PhuongTrinhBacHai()
        {
        }

        public PhuongTrinhBacHai(double a260, double b260, double c260)
        {
            this.A260 = a260;
            this.B260 = b260;
            this.C260 = c260;
        }
        public Double Delta()
        {
            this.DELTA_260 = (this.b260 * this.b260) - 4 * a260 * c260;
            return this.DELTA_260;
        }
        public void TinhNghiem()
        {
            if(this.DELTA_260 < 0)
            {
                Console.WriteLine("Phuong trình vô nghiệm");
            }
            else
            {
                if(this.DELTA_260 > 0)
                {
                    Console.WriteLine("Phuong trình có 2 nghiệm ");
                    x1260 = (-this.b260 + Math.Sqrt( this.DELTA_260)) /( 2*a260);
                    x2260 = (-this.b260 - Math.Sqrt(this.DELTA_260)) / (2 * a260);
                    Console.WriteLine("x1 : " + x1260);
                    Console.WriteLine("x2 : " + x2260);
                }
                else
                {
                    
                    x260 = -b260 / (2 * a260);
                    Console.WriteLine("Phuong trình có 1 nghiệm " +x260);
                }
            }
        }
    }
}
