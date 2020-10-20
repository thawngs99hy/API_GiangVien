using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Giangvien
    {
        public Giangvien()
        {
            Gioday = new HashSet<Gioday>();
            Hocvan = new HashSet<Hocvan>();
            Khenthuong = new HashSet<Khenthuong>();
            Khoahoc = new HashSet<Khoahoc>();
            Lichlamviec = new HashSet<Lichlamviec>();
        }

        public int MaGv { get; set; }
        public int MaBm { get; set; }
        public string TenGv { get; set; }
        public string ChucVu { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string NoiLamViec { get; set; }
        public string QuaTrinhDaoTao { get; set; }
        public string MonGiangDay { get; set; }
        public string LinhvucNghienCuu { get; set; }
        public string HoSo { get; set; }
        public string Img { get; set; }
        public string Website { get; set; }
        public int? MaBac { get; set; }
        public string Gioitinh { get; set; }
        public string NoiOhienTai { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public int? Cmnd { get; set; }
        public DateTime? NgayCap { get; set; }
        public string NoiCap { get; set; }
        public DateTime? NgayKetNapDang { get; set; }
        public string NoiKetNap { get; set; }
        public int? TrangThai { get; set; }
        public int? MaMh { get; set; }

        public virtual Bomontrungtam MaBmNavigation { get; set; }
        public virtual ICollection<Gioday> Gioday { get; set; }
        public virtual ICollection<Hocvan> Hocvan { get; set; }
        public virtual ICollection<Khenthuong> Khenthuong { get; set; }
        public virtual ICollection<Khoahoc> Khoahoc { get; set; }
        public virtual ICollection<Lichlamviec> Lichlamviec { get; set; }
    }
}
