using System;
using System.Collections.Generic;

class SinhVien
{
    public string HoTen { get; set; }
    public string QueQuan { get; set; }
    public int NamSinh { get; set; }
    public double DiemTongKet { get; set; }

    // Hàm tạo không tham số
    public SinhVien() 
    { 
    }

    // Hàm tạo có tham số
    public SinhVien(string hoTen, string queQuan, int namSinh, double diemTongKet)
    {
        HoTen = hoTen;
        QueQuan = queQuan;
        NamSinh = namSinh;
        DiemTongKet = diemTongKet;
    }

    // Hàm nhập thông tin sinh viên
    public void Nhap()
    {
        Console.Write("Nhap ho va ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap que quan: ");
        QueQuan = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap diem tong ket: ");
        DiemTongKet = double.Parse(Console.ReadLine());
    }

    // Hàm xuất thông tin sinh viên
    public void Xuat()
    {
        Console.WriteLine($"Ho va ten: {HoTen}, Que quan: {QueQuan}, Nam sinh: {NamSinh}, Diem tong ket: {DiemTongKet}");
    }
}

class Program
{
    static List<SinhVien> danhSachSinhVien = new List<SinhVien>();

    // Tạo danh sách sinh viên
    static void TaoDanhSach()
    {
        Console.Write("Nhap so luong sinh vien: ");
        int soLuong = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}:");
            SinhVien sv = new SinhVien();
            sv.Nhap();
            danhSachSinhVien.Add(sv);
        }
    }

    // Sửa thông tin sinh viên
    static void SuaThongTin(string hoTen)
    {
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.HoTen == hoTen)
            {
                Console.WriteLine("Nhap lai thong tin sinh vien:");
                sv.Nhap();
                return;
            }
        }
        Console.WriteLine($"Khong tim thay sinh vien co ten: {hoTen}");
    }

    // Xóa sinh viên khỏi danh sách
    static void XoaSinhVien(string hoTen)
    {
        SinhVien svXoa = null;

        foreach (var sv in danhSachSinhVien)
        {
            if (sv.HoTen == hoTen)
            {
                svXoa = sv;
                break;
            }
        }

        if (svXoa != null)
        {
            danhSachSinhVien.Remove(svXoa);
            Console.WriteLine($"Da xoa sinh vien {hoTen} khoi danh sach.");
        }
        else
        {
            Console.WriteLine($"Khong tim thay sinh vien co ten: {hoTen}");
        }
    }

    // Hiển thị sinh viên quê Nam Định
    static void SinhVienQueNamDinh()
    {
        Console.WriteLine("Nhung sinh vien co que nam dinh:");
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.QueQuan.ToLower() == "nam định")
            {
                sv.Xuat();
            }
        }
    }

    // Hiển thị sinh viên có điểm tổng kết cao nhất
    static void SinhVienDiemCaoNhat()
    {
        if (danhSachSinhVien.Count == 0)
        {
            Console.WriteLine("Danh sach sinh vien trong.");
            return;
        }

        double maxDiem = double.MinValue;

        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTongKet > maxDiem)
            {
                maxDiem = sv.DiemTongKet;
            }
        }

        Console.WriteLine("Nhung sinh vien co diem tong ket cao nhat:");
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTongKet == maxDiem)
            {
                sv.Xuat();
            }
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Tap danh sach sinh vien");
            Console.WriteLine("2. Sua thong tin sinh vien");
            Console.WriteLine("3. Xoa sinh vien ra khoi danh sach");
            Console.WriteLine("4. Hien thi sinh vien co que Nam Dinh");
            Console.WriteLine("5. Hien thi sinh vien co diem tong ket cao nhat");
            Console.WriteLine("6. Thoat");
            Console.Write("Chon mot tuy chon: ");

            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    TaoDanhSach();
                    break;
                case "2":
                    Console.Write("Nhap ten sinh vien can sua: ");
                    string tenSua = Console.ReadLine();
                    SuaThongTin(tenSua);
                    break;
                case "3":
                    Console.Write("Nhap ten sinh vien can xoa: ");
                    string tenXoa = Console.ReadLine();
                    XoaSinhVien(tenXoa);
                    break;
                case "4":
                    SinhVienQueNamDinh();
                    break;
                case "5":
                    SinhVienDiemCaoNhat();
                    break;
                case "6":
                    Console.WriteLine("Thoat chuong trinh.");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le, Vui long nhap lai.");
                    break;
            }
        }
    }
}

