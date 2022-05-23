using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__01__managerStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int totalStudent = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            NhapSinhVien(ref students, totalStudent);
            XuatSinhVien(students);
            Console.ReadKey();
        }

        public static void NhapSinhVien(ref List<Student> students, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("---------sinh vien " +
                    ""+(i+1)+" ---------");
                Console.Write("Nhap ten sinh vien ");
                string name_260 = Console.ReadLine();
                string id_260 = Console.ReadLine();
                string khoa_260 = Console.ReadLine();
                double dtb_260 = double.Parse(Console.ReadLine());
                Student student_260 = new Student(id_260, name_260, khoa_260, dtb_260);
                students.Add(student_260);
            }
        }
        public static void XuatSinhVien(List<Student> students)
        {
            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[0].export(i + 1));
            }
        }
    }
}
