using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStruct_forEach
{
   

   
    internal class Program
    {
        enum GioiTinh
        {
            Nam = 1,
            Nu = 0
        }
        struct SinhVien
        {
            public int MaSo260;
            public string HoTen260;
            public double DiemToan260;
            public double DiemLy260;
            public double DiemVan260;
            public double DiemTB260;
            public GioiTinh GioiTinh260;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sinh vien : ");
            int n = int.Parse(Console.ReadLine());
            
            SinhVien[] arrSV260 = new SinhVien[n];
            for (int i = 0; i <n; i++)
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien = NhapThongTinSinhVien(sinhVien,i+1);
                arrSV260[i] = sinhVien;
            }
            int dem = 1;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Danh sach tat ca sinh vien");
            foreach (SinhVien sv in arrSV260)
            {
                Console.WriteLine("Sinh vien thu " + dem);
                XuatThongTinSinhVien(sv);
                dem++;
            }
          
            Console.WriteLine("------------------------------");
            Console.WriteLine("Nhap ten sinh vien can tim");
            String nameFind = Console.ReadLine();
            foreach (SinhVien sv in arrSV260)
            {
               if(sv.HoTen260 == nameFind)
                {
                    XuatThongTinSinhVien(sv);
                }
            }
            Console.ReadLine();
        }
        static SinhVien NhapThongTinSinhVien(SinhVien SV, int i)
        {
            Console.WriteLine("Nhap sinh vien thu " + i);
            Console.Write(" Ma so: ");
            SV.MaSo260 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen260 = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan260 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy260 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan260 = Double.Parse(Console.ReadLine());
            Console.Write("Gioi TInh: nam/nu: ");
            SV.GioiTinh260 =  (Console.ReadLine()) == "nam" ? GioiTinh.Nam : GioiTinh.Nu;
            SV.DiemTB260 = (SV.DiemToan260 + SV.DiemVan260 + SV.DiemLy260) / 3;
            return SV;

        }
        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSo260);
            Console.WriteLine(" Ho ten: " + SV.HoTen260);
            Console.WriteLine(" Gioi Tinh: " + SV.GioiTinh260);
            Console.WriteLine(" Diem toan: " + SV.DiemToan260);
            Console.WriteLine(" Diem ly: " + SV.DiemLy260);
            Console.WriteLine(" Diem van: " + SV.DiemVan260);
            Console.WriteLine(" Diem TB: " + SV.DiemTB260);
        }

    }
}
