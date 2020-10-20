using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Gioday
    {
        public int MaGd { get; set; }
        public int MaGv { get; set; }
        public DateTime NgayBd { get; set; }
        public string GhiChu { get; set; }
        public int? TrangThai { get; set; }

        public virtual Giangvien MaGvNavigation { get; set; }
    }
}
