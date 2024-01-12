using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
   class NuocUong : SanPham
    {
        private double _loinhuan;
        private double _phiGiuLanh;

        public NuocUong() : base() { }

        public NuocUong(string ten, double giamua) : base(ten, giamua)
        {
            _loinhuan = GiaMua * 0.15;
            _phiGiuLanh = GiaMua * 0.1;
        }

        public override double TinhGiaBan()
        {
            return GiaMua + _loinhuan + _phiGiuLanh;
        }

        public override string InChiTiet()
        {
            return string.Format("Ten: {0} - Gia ban: {1: #,##0}", Ten, TinhGiaBan());
        }

        public override void Nhap()
        {
            base.Nhap();
            _loinhuan = GiaMua * 0.15;
            _phiGiuLanh = GiaMua * 0.1;
        }
    }
}
