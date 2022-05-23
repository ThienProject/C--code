using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__01__managerStudent
{
    internal class Student
    {
        private string SDI_260;
        private string ten_260;
        private string khoa_260;
        private double dtb_260;

        public Student(string sDI_260, string ten_260, string khoa_260, double dtb_260)
        {
            SDI_260 = sDI_260;
            this.ten_260 = ten_260;
            this.khoa_260 = khoa_260;
            this.dtb_260 = dtb_260;
        }

        public string SDI_2601 { get => SDI_260; set => SDI_260 = value; }
        public string Ten_260 { get => ten_260; set => ten_260 = value; }
        public string Khoa_260 { get => khoa_260; set => khoa_260 = value; }
        public double Dtb_260 { get => dtb_260; set => dtb_260 = value; }

        public string export(int index)
        {
            return "Sinh vien "+index + ": \n { ma sinh vien : "+this.SDI_260 +
                        " ten sinh vien" +this.ten_260 +
                        " Khoa : " + this.khoa_260 +
                        " tbl : " + this.dtb_260  ;
        }
    }
}
