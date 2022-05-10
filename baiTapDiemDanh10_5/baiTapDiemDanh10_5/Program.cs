using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTapDiemDanh10_5
{
    internal class Program
    {
       static int[] numArray260 = new int[10];
       static int  max260 = 0;
       static int min260 = 0;
        public static void NhapMang()
        {
            for(int i = 0; i < numArray260.Length; i++)
            {
                Console.WriteLine("Nhập số thứ  : " + i+1);
                numArray260[i] = int.Parse(Console.ReadLine());
                if(numArray260[i] > max260)
                {
                    max260 = numArray260[i];
                }
                if(numArray260[i] < min260)
                {
                    min260 = numArray260[i];
                }    

            }
        }
        public static void XuatMang()
        {
            Console.WriteLine("==============Expoxt Array===============");
            for(int i = 0; i < numArray260.Length; i++)
            {
                Console.WriteLine(numArray260[i]);          
            }
        }
        public static void SapXepTangDan()
        {
            for(int i = 0;i< numArray260.Length -1; i++)
            {
                for(int j = i+1; j< numArray260.Length; j++)
                {
                    if(numArray260[i] > numArray260[j])
                    {
                        int tmp = numArray260[j];
                        numArray260[j] = numArray260[i];
                        numArray260[i] = tmp;
                    }
                }    
            }
        }

        public static  void SapXepGiamDan()
        {
            for (int i = 0; i < numArray260.Length - 1; i++)
            {
                for (int j = i + 1; j < numArray260.Length; j++)
                {
                    if (numArray260[i] < numArray260[j])
                    {
                        int tmp = numArray260[j];
                        numArray260[j] = numArray260[i];
                        numArray260[i] = tmp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            NhapMang();
            XuatMang();
            Console.WriteLine("Max = " + max260);
            Console.WriteLine("Min = " + min260);
            SapXepTangDan();
            XuatMang();
            SapXepGiamDan();
            XuatMang();
        }
    }
}
