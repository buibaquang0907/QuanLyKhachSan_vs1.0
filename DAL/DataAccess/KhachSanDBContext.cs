using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class KhachSanDBContext : DbContext
    {
        public KhachSanDBContext()
            : base("name=KhachSanDBContext")
        {
        }

        public virtual DbSet<DICHVU> DICHVU { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<LOAIDICHVU> LOAIDICHVU { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONG { get; set; }
        public virtual DbSet<LOAITIENNGHI> LOAITIENNGHI { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYEN { get; set; }
        public virtual DbSet<PHIEUCHUYENPHONG> PHIEUCHUYENPHONG { get; set; }
        public virtual DbSet<PHIEUDATPHONG> PHIEUDATPHONG { get; set; }
        public virtual DbSet<PHIEUDENBU> PHIEUDENBU { get; set; }
        public virtual DbSet<PHIEUKIEMTRA> PHIEUKIEMTRA { get; set; }
        public virtual DbSet<PHIEULAPDAT> PHIEULAPDAT { get; set; }
        public virtual DbSet<PHIEUSDDV> PHIEUSDDV { get; set; }
        public virtual DbSet<PHONG> PHONG { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }
        public virtual DbSet<TIENNGHI> TIENNGHI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DICHVU>()
                .Property(e => e.GIATHUEDICHVU)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.PHIEUSDDV)
                .WithOptional(e => e.DICHVU)
                .WillCascadeOnDelete();

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DT)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUDATPHONG)
                .WithOptional(e => e.KHACHHANG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LOAIDICHVU>()
                .HasMany(e => e.DICHVU)
                .WithOptional(e => e.LOAIDICHVU)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LOAIPHONG>()
                .Property(e => e.GIATHUE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHONG)
                .WithOptional(e => e.LOAIPHONG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LOAITIENNGHI>()
                .HasMany(e => e.TIENNGHI)
                .WithOptional(e => e.LOAITIENNGHI)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.DT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADON)
                .WithOptional(e => e.NHANVIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TAIKHOAN)
                .WithOptional(e => e.NHANVIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUDATPHONG)
                .WithOptional(e => e.NHANVIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUKIEMTRA)
                .WithOptional(e => e.NHANVIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEULAPDAT)
                .WithOptional(e => e.NHANVIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUSDDV)
                .WithOptional(e => e.NHANVIEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHANQUYEN>()
                .HasMany(e => e.TAIKHOAN)
                .WithOptional(e => e.PHANQUYEN)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHIEUDATPHONG>()
                .Property(e => e.TIENCOC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUDENBU>()
                .Property(e => e.TIENPHAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUKIEMTRA>()
                .HasMany(e => e.PHIEUDENBU)
                .WithOptional(e => e.PHIEUKIEMTRA)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUCHUYENPHONG)
                .WithOptional(e => e.PHONG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUDATPHONG)
                .WithOptional(e => e.PHONG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEULAPDAT)
                .WithOptional(e => e.PHONG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TIENNGHI>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TIENNGHI>()
                .HasMany(e => e.PHIEULAPDAT)
                .WithOptional(e => e.TIENNGHI)
                .WillCascadeOnDelete();
        }
    }
}
