using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Socola : SanPham
    {
        private double _loinhuan;

        public Socola() : base() { }

        public Socola(string ten, double giamua) : base(ten, giamua)
        {
            _loinhuan = GiaMua * 0.2;
        }

        public override double TinhGiaBan()
        {
            return GiaMua + _loinhuan;
        }
        public override string InChiTiet()
        {
            return string.Format("Ten: {0} - Gia ban: {1: #,##0}", Ten, TinhGiaBan());
        }

        public override void Nhap()
        {
            base.Nhap();
            _loinhuan = GiaMua * 0.2;
        }
    }

}
