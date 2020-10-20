using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Khenthuong
    {
        public int MaKt { get; set; }
        public int MaGv { get; set; }
        public string Ten { get; set; }
        public string LyDo { get; set; }
        public DateTime? Ngay { get; set; }
        public string HinhThuc { get; set; }
        public string GhiChu { get; set; }
        public int? TrangThai { get; set; }

        public virtual Giangvien MaGvNavigation { get; set; }
    }
}
