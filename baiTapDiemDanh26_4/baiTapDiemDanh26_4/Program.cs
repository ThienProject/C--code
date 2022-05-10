using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTapDiemDanh26_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a260, b260, c260;
            
            Console.WriteLine("Nhap a");
            a260 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b");
            b260 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap c");
            c260 = double.Parse(Console.ReadLine());

            PhuongTrinhBacHai ptb2 = new PhuongTrinhBacHai(a260,b260,c260);
            ptb2.Delta();

            ptb2.TinhNghiem();
            Console.ReadKey();
        }
    }
}
