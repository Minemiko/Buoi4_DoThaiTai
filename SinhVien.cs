using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_DoThaiTai
{
    internal class SinhVien : Nguoi
    {
        string mssv;
        string nganhHoc;
        double dtb;

        public string Mssv { get => mssv; set => mssv = value; }
        public string NganhHoc { get => nganhHoc; set => nganhHoc = value; }
        public double Dtb { get => dtb; set => dtb = value; }

        public SinhVien() : base () { }

        public SinhVien(string HoTen, DateTime Ngaysinh, string GioiTinh, string Mssv, string Nganhhoc, double Dtb) : base(HoTen, Ngaysinh, GioiTinh)
        {
            this.mssv = Mssv;
            this.nganhHoc = Nganhhoc;
            this.dtb = Dtb;
        }
    }
}
