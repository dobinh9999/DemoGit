using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3xaydunglopVanDongVien
{
    class VanDongVien
    {
        // Thuộc tính
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string MonThiDau { get; set; }
        public double CanNang { get; set; }
        public double ChieuCao { get; set; }

        // Hàm thiết lập không tham số
        public VanDongVien() { }

        // Hàm thiết lập 5 tham số
        public VanDongVien(string hoTen, int tuoi, string monThiDau, double canNang, double chieuCao)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            MonThiDau = monThiDau;
            CanNang = canNang;
            ChieuCao = chieuCao;
        }

        // Hàm xuất thông tin vận động viên
        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Tuoi: {Tuoi}, Mon thi dau: {MonThiDau}, Can nang: {CanNang}, Chieu cao: {ChieuCao}");
        }
    }

    class Program
    {
        static List<VanDongVien> danhSachVDV = new List<VanDongVien>();

        // Hàm nhập thông tin cho một vận động viên
        static VanDongVien NhapThongTin()
        {
            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhap mon thi dau: ");
            string monThiDau = Console.ReadLine();

            Console.Write("Nhap can nang: ");
            double canNang = double.Parse(Console.ReadLine());

            Console.Write("Nhap chieu cao: ");
            double chieuCao = double.Parse(Console.ReadLine());

            return new VanDongVien(hoTen, tuoi, monThiDau, canNang, chieuCao);
        }

        // Hàm xuất danh sách vận động viên
        static void XuatDanhSach(List<VanDongVien> danhSach)
        {
            foreach (var vdv in danhSach)
            {
                vdv.Xuat();
            }
        }

        // Hàm sắp xếp danh sách theo chiều cao tăng dần
        static void SapXepTheoChieuCao(List<VanDongVien> danhSach)
        {
            danhSach.Sort((vdv1, vdv2) => vdv1.ChieuCao.CompareTo(vdv2.ChieuCao));
        }

        static void Main()
        {
            bool thoat = false;

            while (!thoat)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Khai bao van dong vien p");
                Console.WriteLine("2. Nhap danh sach van dong vien");
                Console.WriteLine("3. Hien thi danh sach van dong vien");
                Console.WriteLine("4. Sap xep danh sach theo chieu cao tang dan");
                Console.WriteLine("5. Thoat");
                Console.Write("Chon mot tuy chon: ");

                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        // Khai bao doi tuong p su dung ham thiet lap 5 tham so
                        VanDongVien p = new VanDongVien("Nguyen Van A", 25, "Boi loi", 70.5, 1.75);
                        Console.WriteLine("Thong tin van dong vien p:");
                        p.Xuat();
                        break;

                    case "2":
                        // Nhap danh sach van dong vien
                        Console.Write("Nhap so luong van dong vien: ");
                        int n = int.Parse(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\nNhap thong tin van dong vien thu {i + 1}:");
                            VanDongVien vdv = NhapThongTin();
                            danhSachVDV.Add(vdv);
                        }
                        break;

                    case "3":
                        // Hien thi danh sach van dong vien da nhap
                        if (danhSachVDV.Count == 0)
                        {
                            Console.WriteLine("Danh sach trong.");
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach van dong vien da nhap:");
                            XuatDanhSach(danhSachVDV);
                        }
                        break;

                    case "4":
                        // Sap xep danh sach theo chieu cao tang dan
                        if (danhSachVDV.Count == 0)
                        {
                            Console.WriteLine("Danh sach trong.");
                        }
                        else
                        {
                            SapXepTheoChieuCao(danhSachVDV);
                            Console.WriteLine("\nDanh sach van dong vien sau khi sap xep theo chieu cao:");
                            XuatDanhSach(danhSachVDV);
                        }
                        break;

                    case "5":
                        thoat = true;
                        Console.WriteLine("Thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            }
        }
    }
}
