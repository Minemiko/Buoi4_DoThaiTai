using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_DoThaiTai
{
    public class Nguoi
    {
        string hoTen;
        DateTime ngaySinh;
        string gioiTinh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public Nguoi() { }

        public Nguoi (string HoTen, DateTime Ngaysinh, string GioiTinh)
        {
            this.hoTen = HoTen;
            this.ngaySinh = Ngaysinh;
            this.gioiTinh = GioiTinh;
        }
    }
}
