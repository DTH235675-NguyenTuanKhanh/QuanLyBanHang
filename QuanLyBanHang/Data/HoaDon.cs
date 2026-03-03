using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyBanHang.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public virtual ObservableCollectionListSource<HoaDonChiTiet> HoaDonChiTiet { get; } = new();
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }

    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } 
        public int KhachHangID { get; set; }
        public string HoVaTenKhachHang { get; set; } 
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public string? XemChiTiet { get; set; } 
        public double? TongTienHoaDon { get; set; } 
    }

}