using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_GiangVien.Models
{
    public partial class QLGVContext : DbContext
    {
        public QLGVContext()
        {
        }

        public QLGVContext(DbContextOptions<QLGVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bacluong> Bacluong { get; set; }
        public virtual DbSet<Bomontrungtam> Bomontrungtam { get; set; }
        public virtual DbSet<Chucvu> Chucvu { get; set; }
        public virtual DbSet<Giangvien> Giangvien { get; set; }
        public virtual DbSet<Gioday> Gioday { get; set; }
        public virtual DbSet<Hocvan> Hocvan { get; set; }
        public virtual DbSet<Khenthuong> Khenthuong { get; set; }
        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<Khoahoc> Khoahoc { get; set; }
        public virtual DbSet<Lichlamviec> Lichlamviec { get; set; }
        public virtual DbSet<Luong> Luong { get; set; }
        public virtual DbSet<Monhoc> Monhoc { get; set; }
        public virtual DbSet<Sukien> Sukien { get; set; }
        public virtual DbSet<User2> User2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSI\\THAWNGS;Database=QLGV;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bacluong>(entity =>
            {
                entity.HasKey(e => e.MaBac)
                    .HasName("PK__BACLUONG__1B8FFFBD1E9C6449");

                entity.ToTable("BACLUONG");

                entity.Property(e => e.MaBac).HasColumnName("maBac");

                entity.Property(e => e.HsbacLuong).HasColumnName("HSBacLuong");

                entity.Property(e => e.NhomBac).HasMaxLength(50);

                entity.Property(e => e.TenBac)
                    .IsRequired()
                    .HasColumnName("tenBac")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Bomontrungtam>(entity =>
            {
                entity.HasKey(e => e.Mabm)
                    .HasName("PK__BOMONTRU__603FFF9E8F55A748");

                entity.ToTable("BOMONTRUNGTAM");

                entity.Property(e => e.Mabm).HasColumnName("MABM");

                entity.Property(e => e.Fax)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenBm)
                    .IsRequired()
                    .HasColumnName("TenBM")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Chucvu>(entity =>
            {
                entity.HasKey(e => e.MaCv)
                    .HasName("CHUCVU_pk");

                entity.ToTable("CHUCVU");

                entity.Property(e => e.MaCv).HasColumnName("maCV");

                entity.Property(e => e.TenCv)
                    .HasColumnName("tenCV")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Giangvien>(entity =>
            {
                entity.HasKey(e => e.MaGv)
                    .HasName("PK__GIANGVIE__2725AEF3DE884613");

                entity.ToTable("GIANGVIEN");

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.ChucVu).HasMaxLength(100);

                entity.Property(e => e.Cmnd).HasColumnName("CMND");

                entity.Property(e => e.DanToc).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gioitinh)
                    .HasColumnName("GIOITINH")
                    .HasMaxLength(3);

                entity.Property(e => e.Img)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaBm).HasColumnName("MaBM");

                entity.Property(e => e.MaMh).HasColumnName("maMH");

                entity.Property(e => e.NgayCap).HasColumnType("date");

                entity.Property(e => e.NgayKetNapDang).HasColumnType("date");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.NoiCap).HasMaxLength(50);

                entity.Property(e => e.NoiKetNap).HasMaxLength(50);

                entity.Property(e => e.NoiOhienTai)
                    .HasColumnName("NoiOHienTai")
                    .HasMaxLength(100);

                entity.Property(e => e.QueQuan).HasMaxLength(50);

                entity.Property(e => e.Tel)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenGv)
                    .IsRequired()
                    .HasColumnName("TenGV")
                    .HasMaxLength(50);

                entity.Property(e => e.TonGiao).HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaBmNavigation)
                    .WithMany(p => p.Giangvien)
                    .HasForeignKey(d => d.MaBm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GIANGVIEN__MaBM__267ABA7A");
            });

            modelBuilder.Entity<Gioday>(entity =>
            {
                entity.HasKey(e => e.MaGd)
                    .HasName("PK__GIODAY__7A3E2D670095266C");

                entity.ToTable("GIODAY");

                entity.Property(e => e.MaGd).HasColumnName("maGD");

                entity.Property(e => e.GhiChu).HasColumnType("ntext");

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.NgayBd)
                    .HasColumnName("NgayBD")
                    .HasColumnType("date");

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.Gioday)
                    .HasForeignKey(d => d.MaGv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GIODAY__MaGV__52593CB8");
            });

            modelBuilder.Entity<Hocvan>(entity =>
            {
                entity.HasKey(e => e.MaHv)
                    .HasName("PK__HOCVAN__7A3E149448B97958");

                entity.ToTable("HOCVAN");

                entity.Property(e => e.MaHv).HasColumnName("maHV");

                entity.Property(e => e.ChungChiSuPham).HasColumnType("ntext");

                entity.Property(e => e.ChuyenNganhDaoTao).HasColumnType("ntext");

                entity.Property(e => e.DonViCongTac).HasColumnType("ntext");

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.NamTotNghiep).HasColumnType("date");

                entity.Property(e => e.TenHv)
                    .IsRequired()
                    .HasColumnName("tenHV")
                    .HasMaxLength(100);

                entity.Property(e => e.TrinhDoTinHoc).HasColumnType("ntext");

                entity.Property(e => e.TrinhdoNgoaiNgu).HasColumnType("ntext");

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.Hocvan)
                    .HasForeignKey(d => d.MaGv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOCVAN__MaGV__5812160E");
            });

            modelBuilder.Entity<Khenthuong>(entity =>
            {
                entity.HasKey(e => e.MaKt)
                    .HasName("PK__KHENTHUO__7A3ECFF895FAAFDD");

                entity.ToTable("KHENTHUONG");

                entity.Property(e => e.MaKt).HasColumnName("maKT");

                entity.Property(e => e.GhiChu).HasColumnType("ntext");

                entity.Property(e => e.HinhThuc).HasColumnType("ntext");

                entity.Property(e => e.LyDo).HasColumnType("ntext");

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.Khenthuong)
                    .HasForeignKey(d => d.MaGv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KHENTHUONG__MaGV__5AEE82B9");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.MaKhoa)
                    .HasName("PK__KHOA__C79B8C227D9D1207");

                entity.ToTable("KHOA");

                entity.Property(e => e.MaKhoa).HasColumnName("maKhoa");

                entity.Property(e => e.DiaChiKhoa).HasMaxLength(50);

                entity.Property(e => e.TenKhoa)
                    .IsRequired()
                    .HasColumnName("tenKhoa")
                    .HasMaxLength(100);

                entity.Property(e => e.TruongKhoa).HasMaxLength(50);

                entity.Property(e => e.WebsiteKhoa).HasMaxLength(50);
            });

            modelBuilder.Entity<Khoahoc>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KHOAHOC__7A3ECFE4CA3C0CF3");

                entity.ToTable("KHOAHOC");

                entity.Property(e => e.MaKh).HasColumnName("maKH");

                entity.Property(e => e.GhiChu).HasColumnType("text");

                entity.Property(e => e.Link).HasColumnType("text");

                entity.Property(e => e.LoaiKh)
                    .HasColumnName("loaiKH")
                    .HasMaxLength(255);

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasColumnName("tenKH")
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.Khoahoc)
                    .HasForeignKey(d => d.MaGv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KHOAHOC__MaGV__5535A963");
            });

            modelBuilder.Entity<Lichlamviec>(entity =>
            {
                entity.HasKey(e => e.MaLlv)
                    .HasName("PK__LICHLAMV__3B9BF60FF7AF25B3");

                entity.ToTable("LICHLAMVIEC");

                entity.Property(e => e.MaLlv).HasColumnName("MaLLV");

                entity.Property(e => e.CongViec).HasColumnType("text");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.NgayBd)
                    .HasColumnName("NgayBD")
                    .HasColumnType("date");

                entity.Property(e => e.NgayKt)
                    .HasColumnName("NgayKT")
                    .HasColumnType("date");

                entity.Property(e => e.Thu).HasMaxLength(15);

                entity.Property(e => e.Tuan).HasMaxLength(10);

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.Lichlamviec)
                    .HasForeignKey(d => d.MaGv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LICHLAMVIE__MaGV__2A4B4B5E");
            });

            modelBuilder.Entity<Luong>(entity =>
            {
                entity.HasKey(e => e.MaLuong)
                    .HasName("PK__LUONG__31F4B61190B6B7C5");

                entity.ToTable("LUONG");

                entity.Property(e => e.MaLuong).HasColumnName("maLuong");

                entity.Property(e => e.LuongCb)
                    .HasColumnName("LuongCB")
                    .HasColumnType("money");

                entity.Property(e => e.LuongPc)
                    .HasColumnName("LuongPC")
                    .HasColumnType("money");

                entity.Property(e => e.MaBac).HasColumnName("maBac");

                entity.Property(e => e.NgayHuongLuong).HasColumnType("date");

                entity.Property(e => e.NgayTangLuong).HasColumnType("date");

                entity.HasOne(d => d.MaBacNavigation)
                    .WithMany(p => p.Luong)
                    .HasForeignKey(d => d.MaBac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LUONG__maBac__4F7CD00D");
            });

            modelBuilder.Entity<Monhoc>(entity =>
            {
                entity.HasKey(e => e.MaMh)
                    .HasName("PK__MONHOC__7A3EDFA6A25F974B");

                entity.ToTable("MONHOC");

                entity.Property(e => e.MaMh).HasColumnName("maMH");

                entity.Property(e => e.SoTclt).HasColumnName("SoTCLT");

                entity.Property(e => e.SoTcth).HasColumnName("SoTCTH");

                entity.Property(e => e.TenMh)
                    .IsRequired()
                    .HasColumnName("tenMH")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Sukien>(entity =>
            {
                entity.HasKey(e => e.MaSk)
                    .HasName("PK__SUKIEN__27250811F40AE636");

                entity.ToTable("SUKIEN");

                entity.Property(e => e.MaSk).HasColumnName("MaSK");

                entity.Property(e => e.NgayBd)
                    .HasColumnName("NgayBD")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayKt)
                    .HasColumnName("NgayKT")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasColumnType("text");

                entity.Property(e => e.TenSk)
                    .HasColumnName("TenSK")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<User2>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("user2");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi)
                    .HasColumnName("diachi")
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Gioitinh)
                    .HasColumnName("gioitinh")
                    .HasMaxLength(30);

                entity.Property(e => e.Hoten)
                    .HasColumnName("hoten")
                    .HasMaxLength(150);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("image_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Matkhau)
                    .HasColumnName("matkhau")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasColumnType("date");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Taikhoan)
                    .HasColumnName("taikhoan")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
