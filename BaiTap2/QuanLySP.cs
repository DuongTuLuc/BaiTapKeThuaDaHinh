using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class QuanLySanPham
    {
        private string _ten;
        private SanPham[] dssp;
        private int n;

        public QuanLySanPham()
        {
            _ten = "Cua hang ban le";
            dssp = new SanPham[100];
            n = 0;
        }

        public QuanLySanPham(int size)
        {
            _ten = "Cua hang ban le";
            dssp = new SanPham[100];
            n = 0;
        }

        public void Nhap()
        {
            int chon;
            SanPham sp;
            while (true)
            {
                Console.Write("Hay chon loai san pham ma ban muon (1. Socola - 2. Nuoc uong): ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sp = new Socola();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                    case 2:
                        sp = new NuocUong();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                }
                Console.Write("Ban co muon tiep tuc khong? (0. Thoat): ");
                chon = int.Parse(Console.ReadLine());
                if (chon == 0)
                    break;
            }
        }

        public void InDanhSachSP()
        {
            Console.WriteLine("Ten cua hang: " + _ten);
            Console.WriteLine("----------Danh sach cac san pham----------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dssp[i].InChiTiet());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuanLySanPham quanlySP = new QuanLySanPham();
            quanlySP.Nhap();
            quanlySP.InDanhSachSP();
            Console.ReadLine();
        }
    }
}
