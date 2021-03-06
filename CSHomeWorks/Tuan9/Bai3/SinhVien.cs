﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeWorks.Tuan9.Bai3
{
    class SinhVien : HocSinh
    {
        private bool nckh;

        public bool Nckh { get => nckh; set => nckh = value; }

        public SinhVien() : base()
        {
            nckh = false;
        }
        public SinhVien(string hoTen, DateTime ngaySinh, GioiTinh gioiTinh,double dTB,bool nckh) : base(hoTen, ngaySinh, gioiTinh,dTB)
        {
            this.nckh = nckh;
        }
        public bool XetKhenThuong()
        {
            return nckh && base.XetKhenThuong();
        }
        public void ThongBaoKetQuaKhenThuong()
        {
            if (XetKhenThuong())
            {
                Console.WriteLine(base.HoTen + " duoc khen thuong");
            }
            else
            {
                Console.WriteLine(base.HoTen + " khong duoc khen thuong");
            }
        }
    }
}
