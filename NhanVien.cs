﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_DoThaiTai
{
    internal class NhanVien : Nguoi
    {
        string msnv;
        double luong;
        string chucVu;

        public string Msnv { get => msnv; set => msnv = value; }
        public double Luong { get => luong; set => luong = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public NhanVien() : base() { }

        public NhanVien(string HoTen, DateTime NgaySinh, string GioiTinh, string Msnv, double Luong, string ChucVu) : base(HoTen,NgaySinh,GioiTinh)
        {
            this.msnv = Msnv;
            this.luong = Luong;
            this.chucVu = ChucVu;
        }
    }
}
