using System;

namespace BaiTap2
{
    class SanPham
    {
        private string _ten;
        private double _giamua;

        public SanPham() { }

        public SanPham(string ten, double giamua)
        {
            this._ten = ten;
            this._giamua = giamua;
        }

        public string Ten
        {
            set { _ten = value; }
            get { return _ten; }
        }

        public double GiaMua
        {
            set
            {
                if (value >= 0)
                    _giamua = value;
            }
            get { return _giamua; }
        }

        public virtual double TinhGiaBan()
        {
            return 0;
        }

        public virtual string InChiTiet()
        {
            return _ten;
        }

        public virtual void Nhap()
        {
            Console.Write("\t-Cho biet ten san pham:");
            _ten = Console.ReadLine();
            Console.Write("\t-Cho biet gia mua:");
            _giamua = double.Parse(Console.ReadLine());
        }
    }

   
    

   
}
