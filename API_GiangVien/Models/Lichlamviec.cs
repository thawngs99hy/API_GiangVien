using System;
using System.Collections.Generic;

namespace API_GiangVien.Models
{
    public partial class Lichlamviec
    {
        public int MaLlv { get; set; }
        public int MaGv { get; set; }
        public DateTime? NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }
        public string CongViec { get; set; }
        public string Thu { get; set; }
        public string Tuan { get; set; }
        public string DiaChi { get; set; }

        public virtual Giangvien MaGvNavigation { get; set; }
    }
}
