using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyBanHang.Data
{
    public class QLBHDbContext : DbContext
    {
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer("Data Source=.\\;Database = QLBH;Trusted_Connection = True;TrustServerCertificate = True ");
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBHConnectin"].ConnectionString);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=.\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;TrustServerCertificate=True"
                );
            }
        }
    }
}