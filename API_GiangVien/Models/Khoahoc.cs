using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Khoahoc
    {
        public int MaKh { get; set; }
        public int MaGv { get; set; }
        public string TenKh { get; set; }
        public string LoaiKh { get; set; }
        public string Link { get; set; }
        public string GhiChu { get; set; }
        public int? TrangThai { get; set; }

        public virtual Giangvien MaGvNavigation { get; set; }
    }
}
